namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public class StringDataType2Impl: ModelElementImpl, StringDataType2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StringDataType2Impl(): base() {}
  
  public StringDataType2Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType openXmlElement): base(openXmlElement)
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
