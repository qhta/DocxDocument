namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public partial class ChartLinesTypeImpl: ModelElementImpl, ChartLinesType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartLinesTypeImpl(): base() {}
  
  public ChartLinesTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
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
