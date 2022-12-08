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
  
  public override ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
