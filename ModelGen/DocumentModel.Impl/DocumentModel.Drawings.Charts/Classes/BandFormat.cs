namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Band Format.
/// </summary>
public partial class BandFormatImpl: ModelElementImpl, BandFormat
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.BandFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BandFormat?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BandFormatImpl(): base() {}
  
  public BandFormatImpl(DocumentFormat.OpenXml.Drawing.Charts.BandFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Index != null)
        {
          if (value is not null)
            OpenXmlElement.Index.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Index = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Index = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
        }
      }
    }
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
