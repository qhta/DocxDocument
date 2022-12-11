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
  
  public SeriesTextImpl(): base() {}
  
  public SeriesTextImpl(DocumentFormat.OpenXml.Drawing.Charts.SeriesText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
