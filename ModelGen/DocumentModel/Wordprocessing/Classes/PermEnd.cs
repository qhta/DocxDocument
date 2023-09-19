namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public partial class PermEnd
{
  
  /// <summary>
  ///   Annotation ID
  /// </summary>
  [SchemaAttr("w:id")]
  public Int32? Id { get; set; }
  
  
  /// <summary>
  ///   Annotation Displaced By Custom XML Markup
  /// </summary>
  [SchemaAttr("w:displacedByCustomXml")]
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlValues? DisplacedByCustomXml { get; set; }
  
}
