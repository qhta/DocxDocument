namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public class PageMarginImpl: ModelElementImpl, PageMargin
{
  public DocumentFormat.OpenXml.Wordprocessing.PageMargin? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PageMargin?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageMarginImpl(): base() {}
  
  public PageMarginImpl(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  public Int32? Top
  {
    get => (Int32?)OpenXmlElement?.Top?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Top = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  public UInt32? Right
  {
    get => (UInt32?)OpenXmlElement?.Right?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Right = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  public Int32? Bottom
  {
    get => (Int32?)OpenXmlElement?.Bottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bottom = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  public UInt32? Left
  {
    get => (UInt32?)OpenXmlElement?.Left?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Left = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  public UInt32? Header
  {
    get => (UInt32?)OpenXmlElement?.Header?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Header = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  public UInt32? Footer
  {
    get => (UInt32?)OpenXmlElement?.Footer?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Footer = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  public UInt32? Gutter
  {
    get => (UInt32?)OpenXmlElement?.Gutter?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gutter = (System.UInt32?)value;
    }
  }
  
}
