namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public partial class BookmarkStart
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst { get; set; }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast { get; set; }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
}
