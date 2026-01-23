namespace DocumentModel.Wordprocessing;

public partial class FontProperties
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeAliases() => Aliases is not null;
  public bool ShouldSerializePanose() => Panose is not null;
  public bool ShouldSerializeFontCharSet() => FontCharSet is not null;
  public bool ShouldSerializeFontFamily() => FontFamily is not null;
  public bool ShouldSerializeNotTrueType() => NotTrueType is not null;
  public bool ShouldSerializePitch() => Pitch is not null;
  public bool ShouldSerializeFontSignature() => FontSignature is not null;
}
