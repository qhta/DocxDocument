namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public class RunFontsImpl: ModelElementImpl, RunFonts
{
  public DocumentFormat.OpenXml.Wordprocessing.RunFonts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunFonts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Font Content Type
  /// </summary>
  public FontTypeHintKind? Hint
  {
    get => (FontTypeHintKind?)OpenXmlElement?.Hint?.Value;
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
    get;
    set;
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public String? HighAnsi
  {
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public String? EastAsia
  {
    get;
    set;
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public String? ComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  public ThemeFontKind? AsciiTheme
  {
    get => (ThemeFontKind?)OpenXmlElement?.AsciiTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AsciiTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  public ThemeFontKind? HighAnsiTheme
  {
    get => (ThemeFontKind?)OpenXmlElement?.HighAnsiTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HighAnsiTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  public ThemeFontKind? EastAsiaTheme
  {
    get => (ThemeFontKind?)OpenXmlElement?.EastAsiaTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsiaTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  public ThemeFontKind? ComplexScriptTheme
  {
    get => (ThemeFontKind?)OpenXmlElement?.ComplexScriptTheme?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ComplexScriptTheme = (DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues?)value;
    }
  }
  
}
