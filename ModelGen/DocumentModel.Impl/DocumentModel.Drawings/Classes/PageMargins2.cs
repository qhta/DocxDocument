namespace DocumentModel.Drawings;

/// <summary>
/// Page Margins.
/// </summary>
public class PageMargins2Impl: ModelElementImpl, PageMargins2
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
    get;
    set;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public Double? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public Double? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  public Double? Bottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header
  /// </summary>
  public Double? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footer
  /// </summary>
  public Double? Footer
  {
    get;
    set;
  }
  
}
