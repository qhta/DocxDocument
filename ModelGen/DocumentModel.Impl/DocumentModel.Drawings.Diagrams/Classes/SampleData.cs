namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public class SampleDataImpl: DocumentModel.Drawings.Diagrams.SampleDataTypeImpl, SampleData
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
  
  public new DocumentModel.Drawings.Diagrams.DataModel? DataModel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DataModelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DataModelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
