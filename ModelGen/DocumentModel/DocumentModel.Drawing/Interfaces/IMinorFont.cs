namespace DocumentModel.Drawing;

/// <summary>
/// Minor fonts.
/// </summary>
public interface IMinorFont // : DocumentModel.Drawing.IFontCollectionType
{
  public ITextFontType? LatinFont { get ; set; }
  
  public ITextFontType? EastAsianFont { get ; set; }
  
  public ITextFontType? ComplexScriptFont { get ; set; }
  
  public Collection<ISupplementalFont>? SupplementalFonts { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
