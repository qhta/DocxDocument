namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public class StringDataTypeImpl: ModelElementImpl, StringDataType
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
