namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Minor Gridlines.
/// </summary>
public class MinorGridlinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, MinorGridlines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinorGridlinesImpl(): base() {}
  
  public MinorGridlinesImpl(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines openXmlElement): base(openXmlElement)
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
