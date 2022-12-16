namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Major Gridlines.
/// </summary>
public class MajorGridlinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, MajorGridlines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MajorGridlinesImpl(): base() {}
  
  public MajorGridlinesImpl(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
