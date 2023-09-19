namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public partial class MarkupRangeType
{
  
  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  [SchemaAttr("w:displacedByCustomXml")]
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlValues? DisplacedByCustomXml { get; set; }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [SchemaAttr("w:id")]
  public String? Id { get; set; }
  
}
