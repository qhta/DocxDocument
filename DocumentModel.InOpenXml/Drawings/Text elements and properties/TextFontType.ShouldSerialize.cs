namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class TextFontType
{
  public bool ShouldSerializeTypeface() => Typeface is not null;
  public bool ShouldSerializePanose() => Panose is not null;
  public bool ShouldSerializePitchFamily() => PitchFamily is not null;
  public bool ShouldSerializeCharacterSet() => CharacterSet is not null;
}
