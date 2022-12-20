namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public partial class ShapeDefaultsImpl: ModelElementImpl, ShapeDefaults
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ShapeDefaultsImpl(): base() {}
  
  public ShapeDefaultsImpl(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
        if (item != null)
          return new DocumentModel.Vml.ShapeDefaultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapeDefaultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ShapeLayout? ShapeLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
        if (item != null)
          return new DocumentModel.Vml.ShapeLayoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapeLayoutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
