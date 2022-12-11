namespace DocumentModel.Drawings;

/// <summary>
/// Numeric Point.
/// </summary>
public class NumericPointImpl: ModelElementImpl, NumericPoint
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumericPoint?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumericPointImpl(): base() {}
  
  public NumericPointImpl(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index
  {
    get => (UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public String? FormatCode
  {
    get => (String?)OpenXmlElement?.FormatCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public String? NumericValue
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
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
            item = new DocumentFormat.OpenXml.Drawing.Charts.NumericValue{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
