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
  
  public ThemeOverrideImpl(): base() {}
  
  public ThemeOverrideImpl(DocumentFormat.OpenXml.Drawing.ThemeOverride openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
