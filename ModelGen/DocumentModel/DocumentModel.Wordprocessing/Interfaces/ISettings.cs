namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public interface ISettings // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public DocumentModel.Wordprocessing.IWriteProtection? WriteProtection { get ; set; }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewKind? View { get ; set; }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.IZoom? Zoom { get ; set; }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public System.Boolean? RemovePersonalInformation { get ; set; }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public System.Boolean? RemoveDateAndTime { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public System.Boolean? DoNotDisplayPageBoundaries { get ; set; }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public System.Boolean? DisplayBackgroundShape { get ; set; }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public System.Boolean? PrintPostScriptOverText { get ; set; }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public System.Boolean? PrintFractionalCharacterWidth { get ; set; }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public System.Boolean? PrintFormsData { get ; set; }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public System.Boolean? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public System.Boolean? EmbedSystemFonts { get ; set; }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public System.Boolean? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public System.Boolean? SaveFormsData { get ; set; }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public System.Boolean? MirrorMargins { get ; set; }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public System.Boolean? AlignBorderAndEdges { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public System.Boolean? BordersDoNotSurroundHeader { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public System.Boolean? BordersDoNotSurroundFooter { get ; set; }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public System.Boolean? GutterAtTop { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public System.Boolean? HideSpellingErrors { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public System.Boolean? HideGrammaticalErrors { get ; set; }
  
}
