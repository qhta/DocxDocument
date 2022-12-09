namespace DocumentModel.Drawings;

/// <summary>
/// Page Margins.
/// </summary>
public class PageMargins1Impl: ModelElementImpl, PageMargins1
{
  public DocumentFormat.OpenXml.Drawing.Charts.PageMargins? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PageMargins?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Left
  /// </summary>
  public Double? Left
  {
    get => (Double?)OpenXmlElement?.Left?.Value;
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
    get => (Double?)OpenXmlElement?.Right?.Value;
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
    get => (Double?)OpenXmlElement?.Top?.Value;
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
    get => (Double?)OpenXmlElement?.Bottom?.Value;
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
    get => (Double?)OpenXmlElement?.Header?.Value;
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
    get => (Double?)OpenXmlElement?.Footer?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Footer = (System.Double?)value;
    }
  }
  
}
