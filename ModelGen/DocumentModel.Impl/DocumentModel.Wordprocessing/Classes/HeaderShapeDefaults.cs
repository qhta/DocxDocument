namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public partial class HeaderShapeDefaultsImpl: ModelElementImpl, HeaderShapeDefaults
{
  public DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HeaderShapeDefaultsImpl(): base() {}
  
  public HeaderShapeDefaultsImpl(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Vml.ShapeDefaults? ShapeDefaults
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
