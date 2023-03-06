using DeepEqual.Syntax;

using DocumentModel;

namespace DocumentModel;

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
      Type = type;//(VariantType?)(new VariantTypeNameConverter().ConvertFrom(typeName));
    }
    Value = value;
    //if (value != null)
    //{
    //  if (value is Variant variant)
    //    Value = variant;
    //  else
    //    Value = new Variant(value);
    //}
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
  [XmlAttribute]
  public string? Name { get; set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  //[TypeConverter(typeof(VariantTypeXmlConverter))]
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
  [XmlAttribute]
  public Type? Type { get; set; }

  /// <summary>
  ///   Property ID
  /// </summary>
  [XmlAttribute]
  public Int32? PropertyId { get; set; }

  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  [XmlAttribute]
  public String? LinkTarget { get; set; }

  public override string ToString()
  {
    if (Type != null)
      return $"{Name} ({Type}) = {Value}";
    return $"{Name} = {Value}";
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