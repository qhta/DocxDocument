namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToRangeStart Class.
/// </summary>
public interface IMoveToRangeStart // : DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
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
  public DisplacedByCustomXml? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
