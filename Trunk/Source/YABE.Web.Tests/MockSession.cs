namespace YABE.Web.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Web;
    using System.Web.SessionState;

    /// <summary>
    /// Mock Session
    /// </summary>
    /// <remarks>
    /// Based on the MockSession object in MVC Contrib. 
    /// </remarks>
    public class MockSession : HttpSessionStateBase
    {
        private readonly IDictionary objects;

        public MockSession()
        {
            objects = new Hashtable(StringComparer.OrdinalIgnoreCase);
        }

        #region SessionStateBase

        /// <summary>
        /// Adds the specified object to the mock session.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public override void Add(string name, object value)
        {
            objects.Add(name, value);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public override void Clear()
        {
            objects.Clear();
        }

        /// <summary>
        /// Gets the contents of the MockSession
        /// </summary>
        /// <value>The contents.</value>
        public override HttpSessionStateBase Contents
        {
            get { return this; }
        }

        /// <summary>
        /// Removes the specified object, by name, from the session.
        /// </summary>
        /// <param name="name">The name.</param>
        public override void Remove(string name)
        {
            objects.Remove(name);
        }

        /// <summary>
        /// Removes all objects from session
        /// </summary>
        public override void RemoveAll()
        {
            Clear();
        }

        /// <summary>
        /// Removes an object from session at the specified index
        /// </summary>
        /// <param name="index">The index.</param>
        public override void RemoveAt(int index)
        {
            var key = GetKeyFromIndex(index);
            if (!string.IsNullOrEmpty(key))
            {
                Remove(key);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> from session with the specified name.
        /// </summary>
        /// <value></value>
        public override object this[string name]
        {
            get { return objects[name]; }
            set { objects[name] = value; }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> from session at the specified index.
        /// </summary>
        /// <value></value>
        public override object this[int index]
        {
            get
            {
                var key = GetKeyFromIndex(index);
                return objects[key];
            }
            set
            {
                var key = GetKeyFromIndex(index);
                objects[key] = value;
            }
        }

        /// <summary>
        /// Copies the objects in session to the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public override void CopyTo(Array array, int index)
        {
            objects.CopyTo(array, index);
        }

        /// <summary>
        /// Gets the count of objects in session
        /// </summary>
        /// <value>The count.</value>
        public override int Count
        {
            get { return objects.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is synchronized.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is synchronized; otherwise, <c>false</c>.
        /// </value>
        public override bool IsSynchronized
        {
            get { return objects.IsSynchronized; }
        }

        /// <summary>
        /// Gets the sync root.
        /// </summary>
        /// <value>The sync root.</value>
        public override object SyncRoot
        {
            get { return objects.SyncRoot; }
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns></returns>
        public override IEnumerator GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override void Abandon()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override string SessionID
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override HttpStaticObjectsCollectionBase StaticObjects
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override HttpCookieMode CookieMode
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override bool IsCookieless
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override bool IsNewSession
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        //NameObjectCollectionBase.KeysCollection.ctor is marked internal
        public override NameObjectCollectionBase.KeysCollection Keys
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override int LCID
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override SessionStateMode Mode
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public override int CodePage
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        protected string GetKeyFromIndex(int index)
        {
            if (index < 0 || index >= objects.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var i = objects.Count - 1; //Standard session implements as list, hashtable implements as stack
            foreach (var key in objects.Keys)
            {
                if (i-- == index)
                {
                    return key as string;
                }
            }
            return null;
        }
    }
}