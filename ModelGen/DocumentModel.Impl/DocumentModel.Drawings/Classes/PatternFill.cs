namespace DocumentModel.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public partial class PatternFillImpl: ModelElementImpl, PatternFill
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.PatternFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PatternFill?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PatternFillImpl(): base() {}
  
  public PatternFillImpl(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public DocumentModel.Drawings.PresetPatternKind? Preset
  {
    get => (DocumentModel.Drawings.PresetPatternKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.PresetPatternValues?)value;
    }
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public DocumentModel.Drawings.ForegroundColor? ForegroundColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
        if (item != null)
          return new DocumentModel.Drawings.ForegroundColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ForegroundColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public DocumentModel.Drawings.BackgroundColor? BackgroundColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
        if (item != null)
          return new DocumentModel.Drawings.BackgroundColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BackgroundColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
