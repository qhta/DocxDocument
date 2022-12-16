namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public interface Font
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
  public DocumentModel.HexBinary? Panose1Number { get ; set; }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public DocumentModel.Wordprocessing.FontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public DocumentModel.Wordprocessing.FontFamilyKind? FontFamily { get ; set; }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public Boolean? NotTrueType { get ; set; }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public DocumentModel.Wordprocessing.FontPitchKind? Pitch { get ; set; }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public DocumentModel.Wordprocessing.FontSignature? FontSignature { get ; set; }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedRegularFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldFont { get ; set; }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedItalicFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldItalicFont { get ; set; }
  
}
