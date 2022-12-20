namespace DocumentModel.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public partial class GradientStopListImpl: ModelElementImpl, GradientStopList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.GradientStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GradientStopList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GradientStopListImpl(): base() {}
  
  public GradientStopListImpl(DocumentFormat.OpenXml.Drawing.GradientStopList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.GradientStop? GradientStop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
        if (item != null)
          return new DocumentModel.Drawings.GradientStopImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GradientStopImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
