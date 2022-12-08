namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public class PageMargins1Impl: ModelElementImpl, PageMargins1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? L
  {
    get;
    set;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? R
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? T
  {
    get;
    set;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? B
  {
    get;
    set;
  }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Footer
  {
    get;
    set;
  }
  
}
