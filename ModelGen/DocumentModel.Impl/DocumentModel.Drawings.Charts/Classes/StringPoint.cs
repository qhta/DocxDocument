namespace DocumentModel.Drawings.Charts;

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
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
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
    get => (System.String?)OpenXmlElement?.NumericValue?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumericValue != null)
        {
          if (value is not null)
            OpenXmlElement.NumericValue.Text = value;
          else
            OpenXmlElement.NumericValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumericValue = new DocumentFormat.OpenXml.Drawing.Charts.NumericValue{ Text = value };
        }
      }
    }
  }
  
}
