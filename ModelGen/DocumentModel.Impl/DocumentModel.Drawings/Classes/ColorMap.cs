namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorMap Class.
/// </summary>
public class ColorMapImpl: DocumentModel.Drawings.ColorMappingType1Impl, ColorMap
{
  public new DocumentFormat.OpenXml.Drawing.ColorMap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorMap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
