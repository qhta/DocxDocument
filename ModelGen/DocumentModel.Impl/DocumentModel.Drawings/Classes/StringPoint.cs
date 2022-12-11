namespace DocumentModel.Drawings;

/// <summary>
/// String Point.
/// </summary>
public class StringPointImpl: ModelElementImpl, StringPoint
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringPoint?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StringPointImpl(): base() {}
  
  public StringPointImpl(DocumentFormat.OpenXml.Drawing.Charts.StringPoint openXmlElement): base(openXmlElement)
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
  /// Text Value.
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
