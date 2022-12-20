namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the UpDownBarType Class.
/// </summary>
public partial class UpDownBarTypeImpl: ModelElementImpl, UpDownBarType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public UpDownBarTypeImpl(): base() {}
  
  public UpDownBarTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType openXmlElement): base(openXmlElement)
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
