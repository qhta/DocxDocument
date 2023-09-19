namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BookmarkStart Class.
/// </summary>
public partial class BookmarkStart
{
  
  /// <summary>
  ///   name
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
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
