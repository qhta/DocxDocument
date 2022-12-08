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
  
  public override DataModel? DataModel
  {
    get;
    set;
  }
  
}
