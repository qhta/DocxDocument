namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NumericValue.
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumericValue>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.NumericValue{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
