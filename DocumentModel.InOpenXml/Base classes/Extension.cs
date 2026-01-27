namespace DocumentModel;

/// <summary>
///   Represents an extension element for adding additional information to other elements.
/// </summary>
[OpenXmlType(typeof(DXD.Extension))]
public class Extension : ModelElement<DXD.Extension>
{
  /// <summary>
  ///   Uri string that identifies the extension resource or schema.
  /// </summary>
  [XmlAttribute]
  public string? Uri { get; set; }

}