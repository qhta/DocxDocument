using System.Runtime.Serialization;

namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
[KnownType(typeof(CustomDocumentProperty))]
public partial class DocumentProperty : IEquatable<DocumentProperty>
{
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  [XmlAttribute]
  public string? Name { get; set; }

  /// <summary>
  /// Value of the property
  /// </summary>
  public object? Value { get; set; }

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

  public bool Equals(DocumentProperty? other)
  {
    if (other == null) return false;
    if (this.Name != other.Name)
      return false;
    if (this.Value == other.Value)
      return true;
    if (this.Value is DateTime dt1 && other.Value is DateTime dt2)
      return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day 
             && dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute && dt1.Second == dt2.Second;
    return false;
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }
}
