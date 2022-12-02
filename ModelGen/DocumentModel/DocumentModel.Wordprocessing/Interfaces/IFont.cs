namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public interface IFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public String? AltName { get ; set; }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Panose1Number { get ; set; }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public IFontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public FontFamilyKind? FontFamily { get ; set; }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public Boolean? NotTrueType { get ; set; }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public FontPitchKind? Pitch { get ; set; }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public IFontSignature? FontSignature { get ; set; }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public IFontRelationshipType? EmbedRegularFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public IFontRelationshipType? EmbedBoldFont { get ; set; }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public IFontRelationshipType? EmbedItalicFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public IFontRelationshipType? EmbedBoldItalicFont { get ; set; }
  
}
