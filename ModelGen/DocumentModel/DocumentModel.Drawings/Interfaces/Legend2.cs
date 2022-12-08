namespace DocumentModel.Drawings;

/// <summary>
/// Legend data and formatting.
/// </summary>
public interface Legend2
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public LegendPositionKind? LegendPosition { get ; set; }
  
  public Collection<LegendEntry>? LegendEntries { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
  public Boolean? Overlay { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties2? TextProperties { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
