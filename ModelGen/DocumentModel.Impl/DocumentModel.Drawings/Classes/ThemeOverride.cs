namespace DocumentModel.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public class ThemeOverrideImpl: ModelElementImpl, ThemeOverride
{
  public DocumentFormat.OpenXml.Drawing.ThemeOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ThemeOverride?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public FontScheme? FontScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public FormatScheme? FormatScheme
  {
    get;
    set;
  }
  
}
