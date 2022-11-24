namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public interface ISettings // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public IWriteProtection? WriteProtection { get ; set; }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues>? View { get ; set; }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public IZoom? Zoom { get ; set; }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public IRemovePersonalInformation? RemovePersonalInformation { get ; set; }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public IRemoveDateAndTime? RemoveDateAndTime { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public IDoNotDisplayPageBoundaries? DoNotDisplayPageBoundaries { get ; set; }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public IDisplayBackgroundShape? DisplayBackgroundShape { get ; set; }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public IPrintPostScriptOverText? PrintPostScriptOverText { get ; set; }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public IPrintFractionalCharacterWidth? PrintFractionalCharacterWidth { get ; set; }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public IPrintFormsData? PrintFormsData { get ; set; }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public IEmbedTrueTypeFonts? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public IEmbedSystemFonts? EmbedSystemFonts { get ; set; }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public ISaveSubsetFonts? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public ISaveFormsData? SaveFormsData { get ; set; }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public IMirrorMargins? MirrorMargins { get ; set; }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public IAlignBorderAndEdges? AlignBorderAndEdges { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public IBordersDoNotSurroundHeader? BordersDoNotSurroundHeader { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public IBordersDoNotSurroundFooter? BordersDoNotSurroundFooter { get ; set; }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public IGutterAtTop? GutterAtTop { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public IHideSpellingErrors? HideSpellingErrors { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public IHideGrammaticalErrors? HideGrammaticalErrors { get ; set; }
  
  /// <summary>
  /// Gets the DocumentSettingsPart associated with this element.
  /// </summary>
  public IDocumentSettingsPart? DocumentSettingsPart { get ; set; }
  
}
