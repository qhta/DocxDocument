namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public partial class SeriesTextImpl: ModelElementImpl, SeriesText
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StringReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StringReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
