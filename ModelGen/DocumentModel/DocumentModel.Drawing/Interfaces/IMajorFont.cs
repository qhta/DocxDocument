namespace DocumentModel.Drawing;

/// <summary>
/// Major Font.
/// </summary>
public interface IMajorFont // : DocumentModel.Drawing.IFontCollectionType
{
  public ITextFontType? LatinFont { get ; set; }
  
  public ITextFontType? EastAsianFont { get ; set; }
  
  public ITextFontType? ComplexScriptFont { get ; set; }
  
  public Collection<ISupplementalFont>? SupplementalFonts { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
