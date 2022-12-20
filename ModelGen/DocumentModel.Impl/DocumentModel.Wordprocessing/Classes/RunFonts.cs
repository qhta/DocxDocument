namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public partial class RunFontsImpl: ModelElementImpl, RunFonts
{
  public DocumentFormat.OpenXml.Wordprocessing.RunFonts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunFonts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunFontsImpl(): base() {}
  
  public RunFontsImpl(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Font Content Type
  /// </summary>
  public DocumentModel.Wordprocessing.FontTypeHintKind? Hint
  {
    get => (DocumentModel.Wordprocessing.FontTypeHintKind?)OpenXmlElement?.Hint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hint = (DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues?)value;
    }
  }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  public String? Ascii
  {
    get => (System.String?)OpenXmlElement?.Ascii?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Ascii = (System.String?)value;
    }
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public String? HighAnsi
  {
    get => (System.String?)OpenXmlElement?.HighAnsi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HighAnsi = (System.String?)value;
    }
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public String? EastAsia
  {
    get => (System.String?)OpenXmlElement?.EastAsia?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsia = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public String? ComplexScript
  {
    get => (System.String?)OpenXmlElement?.ComplexScript?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ComplexScript = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? AsciiTheme
  {
    get => (DocumentModel.Wordprocessing.ThemeFontKind?)OpenXmlElement?.AsciiTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AsciiTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? HighAnsiTheme
  {
    get => (DocumentModel.Wordprocessing.ThemeFontKind?)OpenXmlElement?.HighAnsiTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HighAnsiTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? EastAsiaTheme
  {
    get => (DocumentModel.Wordprocessing.ThemeFontKind?)OpenXmlElement?.EastAsiaTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsiaTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? ComplexScriptTheme
  {
    get => (DocumentModel.Wordprocessing.ThemeFontKind?)OpenXmlElement?.ComplexScriptTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ComplexScriptTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
}
