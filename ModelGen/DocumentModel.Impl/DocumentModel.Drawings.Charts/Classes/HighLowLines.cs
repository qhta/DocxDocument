namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the HighLowLines Class.
/// </summary>
public partial class HighLowLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, HighLowLines
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.Charts.HighLowLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.HighLowLines?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HighLowLinesImpl(): base() {}
  
  public HighLowLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.HighLowLines openXmlElement): base(openXmlElement)
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
