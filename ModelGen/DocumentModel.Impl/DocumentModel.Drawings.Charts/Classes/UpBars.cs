namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Up Bars.
/// </summary>
public partial class UpBarsImpl: DocumentModel.Drawings.Charts.UpDownBarTypeImpl, UpBars
{
  public new DocumentFormat.OpenXml.Drawing.Charts.UpBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UpBarsImpl(): base() {}
  
  public UpBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.UpBars openXmlElement): base(openXmlElement)
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
