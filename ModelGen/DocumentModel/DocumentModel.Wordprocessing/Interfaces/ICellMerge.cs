namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public interface ICellMerge // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// vMerge
  /// </summary>
  public VerticalMergeRevisionValues? VerticalMerge { get ; set; }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public VerticalMergeRevisionValues? VerticalMergeOriginal { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
