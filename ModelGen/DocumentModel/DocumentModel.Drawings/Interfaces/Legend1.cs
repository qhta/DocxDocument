namespace DocumentModel.Drawings;

/// <summary>
/// Legend data and formatting.
/// </summary>
public interface Legend1
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public LegendPositionKind? LegendPosition { get ; set; }
  
  public Layout1? Layout { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties1? TextProperties { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
