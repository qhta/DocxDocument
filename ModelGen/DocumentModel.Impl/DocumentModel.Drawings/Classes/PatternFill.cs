namespace DocumentModel.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public class PatternFillImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PatternFill>, PatternFill
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public PresetPatternKind? Preset
  {
    get => (PresetPatternKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.PresetPatternValues?)value;
    }
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public ForegroundColor? ForegroundColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public BackgroundColor? BackgroundColor
  {
    get;
    set;
  }
  
}
