namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public partial class StringDataTypeImpl: ModelElementImpl, StringDataType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringDataType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StringDataTypeImpl(): base() {}
  
  public StringDataTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.StringDataType openXmlElement): base(openXmlElement)
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
