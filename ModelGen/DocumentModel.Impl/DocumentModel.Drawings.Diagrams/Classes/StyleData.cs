namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public partial class StyleDataImpl: DocumentModel.Drawings.Diagrams.SampleDataTypeImpl, StyleData
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
