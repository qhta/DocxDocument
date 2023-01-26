using System.Runtime.Serialization;
using Newtonsoft.Json;

using DocumentModel.Math;

using Qhta.Conversion;
using JsonKnownTypes;

namespace DocumentModel.Properties;

/// <summary>
///   Document Property.
/// </summary>
[KnownType(typeof(CustomDocumentProperty))]
[JsonConverter(typeof(JsonKnownTypesConverter<DocumentProperty>))]
//[JsonDiscriminator(Name = "$type")]
//[JsonKnownType(typeof(DocumentProperty), "DocumentProperty")]
//[JsonKnownType(typeof(CustomDocumentProperty))]
public partial class DocumentProperty : IEquatable<DocumentProperty>
{
  public DocumentProperty(){ }

  public DocumentProperty(string name, object? value = null)
  {
    Name = name;
    Value = value;
  }

  public DocumentProperty(DocumentProperty other)
  { 
    Name = other.Name;
    Value = other.Value;
  }

  public bool Equals(DocumentProperty? other)
  {
    if (other == null) return false;
    if (Name != other.Name)
      return false;
    if (Value == other.Value)
      return true;
    if (Value is DateTime dt1 && other.Value is DateTime dt2)
      return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day
             && dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute && dt1.Second == dt2.Second;
    return false;
  }

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