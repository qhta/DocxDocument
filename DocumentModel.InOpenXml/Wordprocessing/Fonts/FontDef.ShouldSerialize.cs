namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FontDef
{
  public bool ShouldSerializeFontName() => FontName is not null;
  public bool ShouldSerializeAliases() => Aliases is not null;
  public bool ShouldSerializePanose() => Panose is not null;
  public bool ShouldSerializeCharset() => Charset is not null;
  public bool ShouldSerializeFontFamily() => FontFamily is not null;
  public bool ShouldSerializeNotTrueType() => NotTrueType is not null;
  public bool ShouldSerializePitch() => Pitch is not null;
  public bool ShouldSerializeFontSignature() => FontSignature is not null;
}
