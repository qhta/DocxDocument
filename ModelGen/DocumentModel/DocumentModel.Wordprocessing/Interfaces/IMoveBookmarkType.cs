namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public interface IMoveBookmarkType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public System.Int32? ColumnFirst { get ; set; }
  
  /// <summary>
  /// colLast
  /// </summary>
  public System.Int32? ColumnLast { get ; set; }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
}
