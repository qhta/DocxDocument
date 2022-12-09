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
  
  public Layout1? Layout { get ; set; }
  
  public Boolean? Overlay { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties1? TextProperties { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
