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
  
  public ExtraColorSchemeImpl(): base() {}
  
  public ExtraColorSchemeImpl(DocumentFormat.OpenXml.Drawing.ExtraColorScheme openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public DocumentModel.Drawings.ColorMap? ColorMap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
