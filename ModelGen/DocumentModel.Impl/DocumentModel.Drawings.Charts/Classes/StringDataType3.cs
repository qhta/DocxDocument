namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public partial class StringDataType3Impl: ModelElementImpl, StringDataType3
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StringDataType3Impl(): base() {}
  
  public StringDataType3Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PointCount.
  /// </summary>
  public virtual UInt32? PointCount
  {
    get => (System.UInt32?)OpenXmlElement?.PointCount?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PointCount != null)
        {
          if (value is not null)
            OpenXmlElement.PointCount.Val = (System.UInt32?)value;
          else
            OpenXmlElement.PointCount = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PointCount = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
}
