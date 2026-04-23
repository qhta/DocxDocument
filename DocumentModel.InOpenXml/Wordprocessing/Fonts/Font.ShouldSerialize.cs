namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Font
{
  public bool ShouldSerializeFontName() => !String.IsNullOrEmpty(FontName);
  public bool ShouldSerializeAliases() => Aliases is not null && ShouldSerialize(Aliases);
  public bool ShouldSerializePanose() => Panose is not null && ShouldSerialize(Panose);
  public bool ShouldSerializeCharset() => Charset is not null && ShouldSerialize(Charset);
  public bool ShouldSerializeFontFamily() => FontFamily is not null && ShouldSerialize(FontFamily);
  public bool ShouldSerializeNotTrueType() => NotTrueType is not null;
  public bool ShouldSerializePitch() => Pitch is not null && ShouldSerialize(Pitch);
  public bool ShouldSerializeFontSignature() => FontSignature is not null && ShouldSerialize(FontSignature);
  public bool ShouldSerializeEmbedRegularFont() => EmbedRegularFont is not null && ShouldSerialize(EmbedRegularFont);
  public bool ShouldSerializeEmbedBoldFont() => EmbedBoldFont is not null && ShouldSerialize(EmbedBoldFont);
  public bool ShouldSerializeEmbedItalicFont() => EmbedItalicFont is not null && ShouldSerialize(EmbedItalicFont);
  public bool ShouldSerializeEmbedBoldItalicFont() => EmbedBoldItalicFont is not null && ShouldSerialize(EmbedBoldItalicFont);
}
