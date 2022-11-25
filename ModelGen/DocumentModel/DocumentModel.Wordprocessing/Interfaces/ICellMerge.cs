namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public interface ICellMerge // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// vMerge
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMerge { get ; set; }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMergeOriginal { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
}
