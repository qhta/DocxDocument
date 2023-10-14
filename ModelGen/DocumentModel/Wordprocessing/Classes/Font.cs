namespace DocumentModel.Wordprocessing;


/// <summary>
///   Properties for a Single Font.
/// </summary>
public partial class Font
{
  
  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   AltName.
  /// </summary>
  public DocumentModel.Wordprocessing.AltName? AltName { get; set; }
  
  
  /// <summary>
  ///   Panose1Number.
  /// </summary>
  public DM.HexBinary? Panose1Number { get; set; }
  
  
  /// <summary>
  ///   FontCharSet.
  /// </summary>
  public DocumentModel.Wordprocessing.FontCharSet? FontCharSet { get; set; }
  
  
  /// <summary>
  ///   FontFamily.
  /// </summary>
  public DocumentModel.Wordprocessing.FontFamilyKind? FontFamily { get; set; }
  
  
  /// <summary>
  ///   NotTrueType.
  /// </summary>
  public DocumentModel.Wordprocessing.NotTrueType? NotTrueType { get; set; }
  
  
  /// <summary>
  ///   Pitch.
  /// </summary>
  public DocumentModel.Wordprocessing.FontPitchKind? Pitch { get; set; }
  
  
  /// <summary>
  ///   FontSignature.
  /// </summary>
  public DocumentModel.Wordprocessing.FontSignature? FontSignature { get; set; }
  
  
  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedRegularFont? EmbedRegularFont { get; set; }
  
  
  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedBoldFont? EmbedBoldFont { get; set; }
  
  
  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedItalicFont? EmbedItalicFont { get; set; }
  
  
  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedBoldItalicFont? EmbedBoldItalicFont { get; set; }
  
}
