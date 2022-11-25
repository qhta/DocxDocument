namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public interface IFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public System.String? AltName { get ; set; }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Panose1Number { get ; set; }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public DocumentModel.Wordprocessing.FontFamilyKind? FontFamily { get ; set; }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public System.Boolean? NotTrueType { get ; set; }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public DocumentModel.Wordprocessing.FontPitchKind? Pitch { get ; set; }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontSignature? FontSignature { get ; set; }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontRelationshipType? EmbedRegularFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontRelationshipType? EmbedBoldFont { get ; set; }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontRelationshipType? EmbedItalicFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontRelationshipType? EmbedBoldItalicFont { get ; set; }
  
}
