namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Property.
/// </summary>
[XmlContentProperty(nameof(Value))]
public partial class DocumentProperty : ModelElement//IEquatable<DocumentProperty>
{
  public DocumentProperty() { }

  public DocumentProperty(string name, Type? type = null, object? value = null)
  {
    Name = name;
    if (type != null)
    {
      var typeName = type.Name;
      if (typeName.StartsWith("Nullable`"))
        type = type.GenericTypeArguments[0];
      Type = type;
    }
    Value = value;
  }

  public DocumentProperty(DocumentProperty other)
  {
    Name = other.Name;
    Value = other.Value;
  }

  //public bool Equals(DocumentProperty? other)
  //{
  //  if (other == null) return false;
  //  if (this.Name != other.Name)
  //    return false;
  //  if (this.Value != null)
  //  {
  //    var ok = this.Value.IsDeepEqual(other.Value);
  //    //if (!ok)
  //    //{
  //    //  if (this.Value is IEnumerable collection1 && other.Value is IEnumerable collection2)
  //    //  {
  //    //    if (this.Value.GetType().GenericTypeArguments.FirstOrDefault()==other.Value.GetType().GenericTypeArguments.FirstOrDefault())
  //    //    {
  //    //      var methodInfo = typeof(Enumerable).GetMethod("SequenceEqual", BindingFlags.Public | BindingFlags.Static);
  //    //      if (methodInfo != null)
  //    //      {
  //    //        methodInfo = methodInfo.MakeGenericMethod(this.Value.GetType().GenericTypeArguments.First());
  //    //        ok =  (bool)(methodInfo.Invoke(null, new object[]{collection1, collection2 }) ?? false);
  //    //      }
  //    //    }
  //    //  }
  //    //}
  //    return ok;
  //  }
  //  return false;
  //}

  /// <summary>
  ///   Custom File Property Name
  /// </summary>
   public string? Name
  {
    get;
    set;
  }

  /// <summary>
  ///   Value of the property
  /// </summary>
  [TypeConverter(typeof(DocumentPropertyValueXmlConverter))]
  public object? Value
  {
    get => _value;
    set
    {
      if (Type == null && value != null)
        Type = value.GetType();
      //else if (value!=null && value.VariantType != Type && Type!=null)
      //  value.VariantType = (VariantType)Type;
      _value = value;
    }
  }
  private object? _value;

  /// <summary>
  ///   Expected value type name
  /// </summary>
   public Type? Type { get; set; }

  /// <summary>
  ///   Property ID
  /// </summary>
   public Int32? PropertyId { get; set; }

  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
   public String? LinkTarget { get; set; }

  public override string ToString()
  {
    //if (Type != null)
    //  return $"{Name} ({Type}) = {Value}";
    return $"DocumentProperty({Name} = {Value})";
  }

  //public override bool Equals(object? obj)
  //{
  //  if (obj is DocumentProperty other)
  //    return Equals(other);
  //  return base.Equals(obj);
  //}

  //public override int GetHashCode()
  //{
  //  return base.GetHashCode();
  //}
}