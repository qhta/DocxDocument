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
  
  public SampleDataImpl(): base() {}
  
  public SampleDataImpl(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DataModel? DataModel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
