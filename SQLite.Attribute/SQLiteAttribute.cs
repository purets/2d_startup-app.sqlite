using System;

namespace SQLite.Attribute
{

[ AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct) ]
public class ExportAttribute : System.Attribute
{
}

[ AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct) ]
public class TableAttribute : System.Attribute
{
    public TableAttribute(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class ColumnAttribute : System.Attribute
{
    public ColumnAttribute(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class PrimaryKeyAttribute : System.Attribute
{
}

[ AttributeUsage(validOn: AttributeTargets.Property | AttributeTargets.Field) ]
public class AutoIncrementAttribute : System.Attribute
{
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class IndexedAttribute : System.Attribute
{
    public IndexedAttribute()
    {
    }

    public IndexedAttribute(string name, int order)
    {
        this.Name = name;
        this.Order = order;
    }

    public string Name { get; set; }
    public int Order { get; set; }
    public virtual bool Unique { get; set; }
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class IgnoreAttribute : System.Attribute
{
}
[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class SaveAttribute : System.Attribute
{
}


[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class UniqueAttribute : IndexedAttribute
{
    public override bool Unique => true;
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class MaxLengthAttribute : System.Attribute
{
    public MaxLengthAttribute(int length)
    {
        this.Value = length;
    }

    public int Value { get; }
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class CollationAttribute : System.Attribute
{
    public CollationAttribute(string collation)
    {
        this.Value = collation;
    }

    public string Value { get; }
}

[ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
public class NotNullAttribute : System.Attribute
{
}

}
