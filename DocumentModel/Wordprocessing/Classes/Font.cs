namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Properties for a Single Font.
/// </summary>
public class Font: ModelElement//IEquatable<Font>
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

  //public override bool Equals(Font? other)
  //{
  //  if (other != null)
  //  {
  //    if (!string.Equals(this.Name, other.Name)) return false;
  //    if (!string.Equals(this.AltName, other.AltName)) return false;
  //    if (this.Panose != other.Panose) return false;
  //    if (this.FontCharSet != other.FontCharSet) return false;
  //    if (this.FontFamily != other.FontFamily) return false;
  //    if (this.NotTrueType != other.NotTrueType) return false;
  //    if (this.Pitch != other.Pitch) return false;
  //    if (this.FontSignature != other.FontSignature) return false;
  //    if (this.EmbedRegularFont != other.EmbedRegularFont) return false;
  //    if (this.EmbedBoldFont != other.EmbedBoldFont) return false;
  //    if (this.EmbedItalicFont != other.EmbedItalicFont) return false;
  //    if (this.EmbedBoldItalicFont != other.EmbedBoldItalicFont) return false;
  //    return true;
  //  }
  //  return false;
  //}
}