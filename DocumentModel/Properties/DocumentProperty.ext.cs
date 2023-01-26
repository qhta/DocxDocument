using System.Runtime.Serialization;
using Newtonsoft.Json;

using DocumentModel.Math;

using Qhta.Conversion;
using JsonKnownTypes;


namespace DocumentModel.Properties;

/// <summary>
///   Document Property.
/// </summary>
public partial class DocumentProperty : IEquatable<DocumentProperty>
{
  public DocumentProperty() { }

  public DocumentProperty(string name, object? value = null)
  {
    Name = name;
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
    if (Name == "Ukończono")
      Debug.Assert(other != null);
    if (other == null) return false;
    if (this.Name != other.Name)
      return false;
    if (this.Value == other.Value)
      return true;
    //if (this.Value is string str1 && other.Value is string str2)
    //  return String.Equals(str1, str2);
    //if (this.Value is DateTime dt1 && other.Value is DateTime dt2)
    //  return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day
    //         && dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute && dt1.Second == dt2.Second;
    if (this.Value != null)
      return this.Value.Equals(other.Value);
    return false;
  }

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