namespace DocumentModel.Wordprocessing;

/// <summary>
///   Properties for a Single Font.
/// </summary>
public class Font
{
  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   AltName.
  /// </summary>
  public String? AltName { get; set; }

  /// <summary>
  ///   Panose1Number.
  /// </summary>
  [XmlAttribute]
  public HexBinary? Panose { get; set; }

  /// <summary>
  ///   FontCharSet.
  /// </summary>
  public FontCharSet? FontCharSet { get; set; }

  /// <summary>
  ///   FontFamily.
  /// </summary>
  public FontFamilyKind? FontFamily { get; set; }

  /// <summary>
  ///   NotTrueType.
  /// </summary>
  public Boolean? NotTrueType { get; set; }

  /// <summary>
  ///   Pitch.
  /// </summary>
  public FontPitchKind? Pitch { get; set; }

  /// <summary>
  ///   FontSignature.
  /// </summary>
  public FontSignature? FontSignature { get; set; }

  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  public FontRelationshipType? EmbedRegularFont { get; set; }

  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldFont { get; set; }

  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedItalicFont { get; set; }

  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldItalicFont { get; set; }
}