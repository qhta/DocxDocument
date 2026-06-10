using Microsoft.Office.Interop.Word;

namespace DocumentModel;

//[XmlArrayItem("BuiltInProperty", typeof(BuiltInProperty))]
/// <summary>
///   Abstract document Property.
/// </summary>
[XmlRoot("DocumentProperty", Namespace = "DocumentModel")]
public abstract partial class DocumentProperty : NamedModelElement
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty()
  {
  }

  /// <summary>
  ///   Value of the property as a string.
  /// </summary>
  public virtual string? Value { get; set; }

  /// <summary>
  ///   Expected value type
  /// </summary>
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
  public virtual DMPr.DocPropertyType Type { get; set; }
}