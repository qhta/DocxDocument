namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public partial class MajorGridlinesGridlinesImpl: DocumentModel.Drawings.ChartDrawings.OpenXmlGridlinesElementImpl, MajorGridlinesGridlines
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MajorGridlinesGridlinesImpl(): base() {}
  
  public MajorGridlinesGridlinesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
