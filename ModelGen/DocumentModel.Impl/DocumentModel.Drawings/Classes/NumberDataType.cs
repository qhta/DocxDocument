namespace DocumentModel.Drawings;

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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.FormatCode{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Point Count.
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
