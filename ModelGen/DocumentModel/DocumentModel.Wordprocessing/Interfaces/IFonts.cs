namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public interface IFonts // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the FontTablePart associated with this element.
  /// </summary>
  public IFontTablePart? FontTablePart { get ; set; }
  
}
