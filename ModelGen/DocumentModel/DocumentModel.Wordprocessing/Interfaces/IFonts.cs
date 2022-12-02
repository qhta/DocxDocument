namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public interface IFonts // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IFont>? Fonts { get ; set; }
  
}
