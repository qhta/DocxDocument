namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Leader Lines.
/// </summary>
public class LeaderLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, LeaderLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LeaderLinesImpl(): base() {}
  
  public LeaderLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.LeaderLines openXmlElement): base(openXmlElement)
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
