namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public interface Title2
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public ChartText1? ChartText { get ; set; }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout1? Layout { get ; set; }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public Boolean? Overlay { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties1? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
