using System.Xml.Serialization;

namespace ModelDoc;
/// <summary>
/// Represents model property documentation. The same is used for enum value documentation
/// </summary>
public class PropDoc
{
  /// <summary>
  /// Default constructor - needed for deserialization.
  /// </summary>
  public PropDoc() { Tag = ""; }

  /// <summary>
  /// Initializing constructor. As docx does not specify friendly name - it is optional.
  /// </summary>
  /// <param name="tag"></param>
  /// <param name="typeName"></param>
  public PropDoc(string tag, string? typeName)
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
  /// RefName without spaces.
  /// </summary>
  [XmlIgnore]
  public string? Name { get; private set; }

  /// <summary>
  /// Summary paragraphs - usually a single paragraph.
  /// </summary>
  [XmlElement("Summary")]
  public Summary? Summary { get; set; }}
