using System.ComponentModel.DataAnnotations;

using DocumentModel.BaseTypes;

namespace DocumentModel.Properties;

/// <summary>
///   Document Property.
/// </summary>
public partial class DocumentProperty : IEquatable<DocumentProperty>
{
  public DocumentProperty() { }


  public DocumentProperty(string name, Type? type = null, object? value = null)
  {
    Name = name;
    if (type != null)
    {
      var typeName = type.Name;
      if (typeName.StartsWith("Nullable`"))
        typeName = type.GenericTypeArguments[0].Name;
      Type = (VariantType?)(new VariantTypeNameConverter().ConvertFrom(typeName));
    }
    if (value != null)
    {
      if (value is Variant variant)
        Value = variant;
      else
        Value = new Variant(value);
    }
  }

  public DocumentProperty(DocumentProperty other)
  {
    Name = other.Name;
    Value = other.Value;
  }

  public bool Equals(DocumentProperty? other)
  {
    if (other == null) return false;
    if (this.Name != other.Name)
      return false;
    if (this.Value != null)
      return this.Value.Equals(other.Value);
    return false;
  }

  /// <summary>
  ///   Value of the property
  /// </summary>
  [TypeConverter(typeof(VariantTypeXmlConverter))]
  public Variant? Value
  {
    get => _value;
    set
    {
      if (Type == null && value != null)
        Type = value.VariantType;
      else if (value!=null && value.VariantType != Type && Type!=null)
        value.VariantType = (VariantType)Type;
      _value = value;
    }
  }
  private Variant? _value;

  /// <summary>
  ///   Expected value type name
  /// </summary>
  [XmlAttribute]
  public VariantType? Type { get; set; }

  /// <summary>
  ///   Format ID
  /// </summary>
  [XmlAttribute]
  public String? FormatId { get; set; }

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

  public override bool Equals(object? obj)
  {
    if (obj is DocumentProperty other)
      return Equals(other);
    return base.Equals(obj);
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }
}