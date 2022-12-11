namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public class StyleDataImpl: DocumentModel.Drawings.SampleDataTypeImpl, StyleData
{
  public new DocumentFormat.OpenXml.Drawing.Diagrams.StyleData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleDataImpl(): base() {}
  
  public StyleDataImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DataModel? DataModel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
