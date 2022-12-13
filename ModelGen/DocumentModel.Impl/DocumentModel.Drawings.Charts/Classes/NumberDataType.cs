namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public class NumberDataTypeImpl: ModelElementImpl, NumberDataType
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberDataTypeImpl(): base() {}
  
  public NumberDataTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Format Code.
  /// </summary>
  public virtual String? FormatCode
  {
    get => (System.String?)OpenXmlElement?.FormatCode?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FormatCode != null)
        {
          if (value is not null)
            OpenXmlElement.FormatCode.Text = value;
          else
            OpenXmlElement.FormatCode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FormatCode = new DocumentFormat.OpenXml.Drawing.Charts.FormatCode{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Point Count.
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
