namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public interface ValueColorPositions
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
