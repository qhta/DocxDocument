namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface ValueColors
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
