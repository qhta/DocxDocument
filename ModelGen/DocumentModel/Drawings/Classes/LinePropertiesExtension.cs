namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class LinePropertiesExtension
{
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("uri")]
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
  
}
