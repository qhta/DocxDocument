namespace DocumentModel.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public class PatternFillImpl: ModelElementImpl, PatternFill
{
  public DocumentFormat.OpenXml.Drawing.PatternFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PatternFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PatternFillImpl(): base() {}
  
  public PatternFillImpl(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public BackgroundColor? BackgroundColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
