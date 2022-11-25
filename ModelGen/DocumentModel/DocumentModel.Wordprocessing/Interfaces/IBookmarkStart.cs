namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public interface IBookmarkStart // : DocumentModel.ITypedOpenXmlLeafElement
{
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
