namespace DocumentModel;

/// <summary>
///   Represents an extension element for adding additional information to other elements.
/// </summary>
[OpenXmlType(typeof(DXD.Extension))]
public partial class Extension<T> : ModelElement<T> where T: DX.OpenXmlElement
{
  /// <summary>
  ///   Uri string that identifies the extension resource or schema.
  /// </summary>
  [XmlAttribute]
  public string? Uri { get; set; }

}


/// <summary>
/// Concrete class for Extension, representing an extension element for adding additional information to other elements without specifying a particular type parameter.
/// </summary>
public class Extension: Extension<DXD.Extension>
{

}