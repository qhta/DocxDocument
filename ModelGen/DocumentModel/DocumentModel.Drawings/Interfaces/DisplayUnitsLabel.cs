namespace DocumentModel.Drawings;

/// <summary>
/// Display Units Label.
/// </summary>
public interface DisplayUnitsLabel
{
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout2? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText1? ChartText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties2? TextProperties { get ; set; }
  
}
