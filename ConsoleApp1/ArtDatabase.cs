﻿public class Resources 
{
    public class Identifier
    {
        //This is called a "backing field." It's the protected/private internal version of
        // your value, and is the value that's actually modified by the NumberTag property.
        // They're declared as protected to prevent external classes from modifying or accessing
        // them, and should generally start with an _ and be camelCase, whereas the properties
        // are public and written in PascalCase.
        protected int _numberTag = 0;

        public int NumberTag
        {
            get => this._numberTag;
            set
            {
                this._numberTag = value < 0 ? 0 : value;
            }
        }

        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? PathLink { get; set; }
    }

    public class Content
    {

        //Dates are generally declared using the DateTime data type, something like
        // public DateTime DateCreated = DateTime.UtcNow; or similar. Further, the
        // correct way to do arrays is to sorta not do arrays. Use ICollection instead,
        // like this: public ICollection<int> CurrentVersion = new List<int>(new[] { 0, 0, 0 });
        //ICollections/Lists are far more modern and have a lot of features that arrays simply don't.
        public Array DateCreated = new int[] { 0, 0, 0,};
        public Array CurrentVersion = new int[] { 0, 0, 0,};
        public Array FirstVersion = new int[] { 0, 0, 0,};
    }

    public class Ownership
{
    //If you're going to have nullable properties, use nulls. Don't set null values to something else.
    //If you want to read nulls as something else, but still accept the null value, you can override the getter.
    protected string? _author = null;
    protected string? _editor = null;
    public string? Author
    {
        get => _author == null ? "NoName" : _author;
        set {
            _author = value;
        }
    }

    public string? Editor
    {
        get => _editor == null ? "NoName" : _editor;
        set {
            _editor = value;
        }
    }
}

    public string? Description { get; set; }
}