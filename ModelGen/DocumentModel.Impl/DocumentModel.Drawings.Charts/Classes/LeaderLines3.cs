namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
public class LeaderLines3Impl: ModelElementImpl, LeaderLines3
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LeaderLines3Impl(): base() {}
  
  public LeaderLines3Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
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
