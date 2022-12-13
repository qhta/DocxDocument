namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
public class ColorDataImpl: DocumentModel.Drawings.SampleDataTypeImpl, ColorData
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.ColorData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorDataImpl(): base() {}
  
  public ColorDataImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.DataModel? DataModel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
