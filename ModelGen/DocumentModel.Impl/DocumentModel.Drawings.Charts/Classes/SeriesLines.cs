namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SeriesLines Class.
/// </summary>
public partial class SeriesLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, SeriesLines
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.Charts.SeriesLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SeriesLines?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SeriesLinesImpl(): base() {}
  
  public SeriesLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.SeriesLines openXmlElement): base(openXmlElement)
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
