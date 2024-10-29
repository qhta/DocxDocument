using System.Xml.Serialization;

namespace ModelDocumentation;

/// <summary>
/// Represents model type documentation: summary and properties documentation.
/// </summary>
public class TypeDoc
{
  /// <summary>
  /// Default constructor - needed for deserialization.
  /// </summary>
  public TypeDoc() { Tag = ""; }

  /// <summary>
  /// Initializing constructor. As docx does not specify friendly name - it is optional.
  /// </summary>
  /// <param name="tag"></param>
  /// <param name="typeName"></param>
  public TypeDoc(string tag, string? typeName)
  {
    Tag = tag;
    FriendlyName = typeName;
  }

  /// <summary>
  /// XmlTag for a type.
  /// </summary>
  public string Tag { get; set; }

  /// <summary>
  /// Friendly type name.
  /// </summary>
  public string? FriendlyName
  {
    get => _FriendlyName;
    set
    {
      _FriendlyName = value;
      if (value != null)
        Name = value.Replace(" ", "");
    }
  }
  private string? _FriendlyName;

  /// <summary>
  /// Name without spaces.
  /// </summary>
  [XmlIgnore]
  public string? Name { get; private set; }

  /// <summary>
  /// Summary paragraphs - usually a single paragraph.
  /// </summary>
  [XmlElement("Summary")]
  public Summary? Summary { get; set; }

  /// <summary>
  /// Documentation for properties.
  /// </summary>
  [XmlElement("Properties")]
  public Properties? Properties { get; set; }

}
