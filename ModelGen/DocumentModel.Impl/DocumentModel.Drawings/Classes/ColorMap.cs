namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorMap Class.
/// </summary>
public class ColorMapImpl: DocumentModel.Drawings.ColorMappingTypeImpl, ColorMap
{
  public new DocumentFormat.OpenXml.Drawing.ColorMap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorMap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorMapImpl(): base() {}
  
  public ColorMapImpl(DocumentFormat.OpenXml.Drawing.ColorMap openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
