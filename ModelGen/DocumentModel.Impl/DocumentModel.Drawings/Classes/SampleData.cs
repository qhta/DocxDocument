namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public class SampleDataImpl: DocumentModel.Drawings.SampleDataTypeImpl, SampleData
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.SampleData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.SampleData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override DataModel? DataModel
  {
    get;
    set;
  }
  
}
