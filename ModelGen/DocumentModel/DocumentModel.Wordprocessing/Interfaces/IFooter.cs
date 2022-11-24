namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footer.
/// </summary>
public interface IFooter // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the FooterPart associated with this element.
  /// </summary>
  public IFooterPart? FooterPart { get ; set; }
  
}
