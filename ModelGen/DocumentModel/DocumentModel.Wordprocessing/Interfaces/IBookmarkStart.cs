namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public interface IBookmarkStart // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public int? ColumnFirst { get ; set; }
  
  /// <summary>
  /// colLast
  /// </summary>
  public int? ColumnLast { get ; set; }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlValues? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
