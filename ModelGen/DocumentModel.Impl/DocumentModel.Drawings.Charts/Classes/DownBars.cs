namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Down Bars.
/// </summary>
public partial class DownBarsImpl: DocumentModel.Drawings.Charts.UpDownBarTypeImpl, DownBars
{
  public new DocumentFormat.OpenXml.Drawing.Charts.DownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DownBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DownBarsImpl(): base() {}
  
  public DownBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.DownBars openXmlElement): base(openXmlElement)
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
