namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PermStart Class.
/// </summary>
public partial class PermStart
{
  
  /// <summary>
  ///   edGrp
  /// </summary>
  [SchemaAttr("w:edGrp")]
  public DocumentModel.Wordprocessing.RangePermissionEditingGroupValues? EditorGroup { get; set; }
  
  
  /// <summary>
  ///   ed
  /// </summary>
  [SchemaAttr("w:ed")]
  public String? Ed { get; set; }
  
  
  /// <summary>
  ///   colFirst
  /// </summary>
  [SchemaAttr("w:colFirst")]
  public Int32? ColumnFirst { get; set; }
  
  
  /// <summary>
  ///   colLast
  /// </summary>
  [SchemaAttr("w:colLast")]
  public Int32? ColumnLast { get; set; }
  
  
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
