namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public interface IFonts // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IFont>? Fonts { get ; set; }
  
}
