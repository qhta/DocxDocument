namespace DocumentModel.Drawing;

/// <summary>
/// Minor fonts.
/// </summary>
public interface IMinorFont // : DocumentModel.Drawing.IFontCollectionType
{
  public DocumentModel.Drawing.ITextFontType? LatinFont { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? EastAsianFont { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? ComplexScriptFont { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISupplementalFont>? SupplementalFonts { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
