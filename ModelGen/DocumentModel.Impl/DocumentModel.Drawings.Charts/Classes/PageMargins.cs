namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public class PageMarginsImpl: ModelElementImpl, PageMargins
{
  public DocumentFormat.OpenXml.Drawing.Charts.PageMargins? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PageMargins?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageMarginsImpl(): base() {}
  
  public PageMarginsImpl(DocumentFormat.OpenXml.Drawing.Charts.PageMargins openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Left
  /// </summary>
  public Double? Left
  {
    get => (System.Double?)OpenXmlElement?.Left?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Left = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public Double? Right
  {
    get => (System.Double?)OpenXmlElement?.Right?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Right = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public Double? Top
  {
    get => (System.Double?)OpenXmlElement?.Top?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Top = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  public Double? Bottom
  {
    get => (System.Double?)OpenXmlElement?.Bottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bottom = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Header
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
  /// Footer
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
