namespace DocumentModel.Drawings.Charts;

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
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
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
    get => (System.String?)OpenXmlElement?.FormatCode?.Value;
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
