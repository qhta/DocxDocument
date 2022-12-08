namespace DocumentModel.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public class ExtraColorSchemeImpl: ModelElementImpl, ExtraColorScheme
{
  public DocumentFormat.OpenXml.Drawing.ExtraColorScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtraColorScheme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public ColorMap? ColorMap
  {
    get;
    set;
  }
  
}
