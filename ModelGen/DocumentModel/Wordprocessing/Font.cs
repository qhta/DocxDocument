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
  public DMW.AltName? AltName { get; set; }
  
  
  /// <summary>
  ///   Panose1Number.
  /// </summary>
  public DM.HexBinary? Panose1Number { get; set; }
  
  
  /// <summary>
  ///   FontCharSet.
  /// </summary>
  public DMW.FontCharSet? FontCharSet { get; set; }
  
  
  /// <summary>
  ///   FontFamily.
  /// </summary>
  public DMW.FontFamilyKind? FontFamily { get; set; }
  
  
  /// <summary>
  ///   NotTrueType.
  /// </summary>
  public DMW.NotTrueType? NotTrueType { get; set; }
  
  
  /// <summary>
  ///   Pitch.
  /// </summary>
  public DMW.FontPitchKind? Pitch { get; set; }
  
  
  /// <summary>
  ///   FontSignature.
  /// </summary>
  public DMW.FontSignature? FontSignature { get; set; }
  
  
  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  public DMW.EmbedRegularFont? EmbedRegularFont { get; set; }
  
  
  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  public DMW.EmbedBoldFont? EmbedBoldFont { get; set; }
  
  
  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  public DMW.EmbedItalicFont? EmbedItalicFont { get; set; }
  
  
  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  public DMW.EmbedBoldItalicFont? EmbedBoldItalicFont { get; set; }
  
}
