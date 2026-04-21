namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class TextFontType
{
  public bool ShouldSerializeTypeface() => !String.IsNullOrEmpty(Typeface);
  public bool ShouldSerializePanose() => Panose is not null;
  public bool ShouldSerializePitchFamily() => PitchFamily is not null;
  public bool ShouldSerializeCharset() => Charset is not null;
}
