namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public class PageMarginsImpl: ModelElementImpl, PageMargins
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageMarginsImpl(): base() {}
  
  public PageMarginsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? L
  {
    get => (System.Double?)OpenXmlElement?.L?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.L = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? R
  {
    get => (System.Double?)OpenXmlElement?.R?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.R = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? T
  {
    get => (System.Double?)OpenXmlElement?.T?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.T = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? B
  {
    get => (System.Double?)OpenXmlElement?.B?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.B = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Header
  {
    get => (System.Double?)OpenXmlElement?.Header?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Header = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Footer
  {
    get => (System.Double?)OpenXmlElement?.Footer?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Footer = (System.Double?)value;
    }
  }
  
}
