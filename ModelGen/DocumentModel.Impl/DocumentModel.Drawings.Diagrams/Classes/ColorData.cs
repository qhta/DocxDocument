namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
public class ColorDataImpl: DocumentModel.Drawings.Diagrams.SampleDataTypeImpl, ColorData
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
