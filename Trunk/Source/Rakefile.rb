DOT_NET_PATH = "C:/WINDOWS/Microsoft.NET/Framework/v3.5"
SOLUTION = "YABE.sln"
CONFIGURATION = "Debug"
BUILD_PATH = "../Build"
NUNIT_PATH = "../Tools/NUnit/2.4.7"
MIGRATOR_PATH = "../Tools/Migrator"
DATABASE_SERVER = "(local)\\SQL2005"
DEV_DATABASE = "YABE_Dev"
PROD_DATABASE = "YABE_Prod"
TEST_DATABASE = "YABE_Test"
MIGRATION_PATH = "../Build"
MIGRATION_ASM = "YABE.Migrations.dll"
MIGRATION_SCHEMA = "YABE.Migrations/Schema.cs"
NHQG_PATH = "../Tools/NHQG/NHQG.exe"
task :default => ["build:debug"]
task :migrate => ["build:debug", "db:migrate"]

namespace :build do

	desc "Use MSBuild to build the solution: '#{SOLUTION}' in debug mode"
	task :debug => :clean do

		sh "#{DOT_NET_PATH}/msbuild.exe /p:Configuration=debug #{SOLUTION}"
		
		copy_artifacts "debug"
	end
	
	desc "Use MSBuild to build the solution: '#{SOLUTION}' in release mode"
	task :release => :clean do

		sh "#{DOT_NET_PATH}/msbuild.exe /p:Configuration=release #{SOLUTION}"
		
		copy_artifacts "release"
	end
	
	desc "Use MSBuild to clean the solution artifacts and delete the contents of the build folder"
	task :clean do
		sh "#{DOT_NET_PATH}/msbuild.exe #{SOLUTION} /target:clean"
		
		if File.directory?(BUILD_PATH)
			files = Dir.glob("#{BUILD_PATH}/*")
			rm_r files
		end
	end

	desc "Use NUnit to run all tests"
	task :test => :debug do
		tests = Dir.glob(File.join("#{BUILD_PATH}", "*.Tests.dll")).join " "
		xml_file = File.join("#{BUILD_PATH}", "nunit-test-report.xml")
		
		sh "#{NUNIT_PATH}/nunit-console.exe #{tests} /nologo /xml=#{xml_file}"
	end
	
	desc "Generate Query Objects with NHQG"
	task :generate do
		sh "#{NHQG_PATH} /Lang:CS /InputFilePattern:YABE.Infrastructure/DataAccess/Mappings/*.hbm.xml /out:YABE.Infrastructure/DataAccess/Queries"
	end
	
	def copy_artifacts(config)
		unless File.directory?(BUILD_PATH) 
			mkdir BUILD_PATH
		end
		
		items = Dir.glob("YABE.*")
		items.each do |item|
			if File.directory?(item)
				copy_artifacts_in_path item, config
			end
		end
	end	
	
	def copy_artifacts_in_path(artifact_path, config)
		files = Dir.glob("#{artifact_path}/bin/#{config}/*.dll") 
		files.each do |item|
			cp_r item, "#{BUILD_PATH}"
		end
		
		if (config.downcase == "debug")
			files = Dir.glob("#{artifact_path}/bin/#{config}/*.pdb") 
			files.each do |item|
				cp_r item, "#{BUILD_PATH}"
			end	
		end
	end 
end

namespace :db do

	desc "Run database migrations"
	task :migrate do
      
      env = ENV['env']
      version = ENV['ver']
      
      db = case env
        when 'dev' : DEV_DATABASE
        when 'prod' : PROD_DATABASE          
        when 'test' : TEST_DATABASE
        else DEV_DATABASE
      end
     
      connection_string = "server=#{DATABASE_SERVER};database=#{db};uid=yabe;pwd=yabe;"
      if (version == nil)
        migration = "sqlserver2005 \"#{connection_string}\" \"#{MIGRATION_PATH}/#{MIGRATION_ASM}\""
      else
        migration = "sqlserver2005 \"#{connection_string}\" \"#{MIGRATION_PATH}/#{MIGRATION_ASM}'\" -version #{version}"
      end
            
      sh "\"#{MIGRATOR_PATH}/Migrator.Console\" #{migration}"
      
      if (env == 'dev')
        sh "\"#{MIGRATOR_PATH}/Migrator.Console\" #{migration} -dump \"#{MIGRATION_SCHEMA}\" "
	  end
	end
end