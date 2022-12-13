namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public class SeriesTextImpl: ModelElementImpl, SeriesText
{
  public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SeriesText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SeriesTextImpl(): base() {}
  
  public SeriesTextImpl(DocumentFormat.OpenXml.Drawing.Charts.SeriesText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NumericValue.
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
