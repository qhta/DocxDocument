namespace DocumentModel.Drawing;

/// <summary>
/// Pattern Fill.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IForegroundColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBackgroundColor))]
public class PatternFill: IPatternFill
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public PresetPatternValues? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public DocumentModel.Drawing.IForegroundColor? ForegroundColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public DocumentModel.Drawing.IBackgroundColor? BackgroundColor
  {
    get;
    set;
  }
  
}
