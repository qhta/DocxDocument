namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Indentation
{
  public bool ShouldSerializeLeft() => Left is not null;
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeLeftChars() => LeftChars is not null;
  public bool ShouldSerializeStartCharacters() => StartCharacters is not null;
  public bool ShouldSerializeRight() => Right is not null;
  public bool ShouldSerializeEnd() => End is not null;
  public bool ShouldSerializeRightChars() => RightChars is not null;
  public bool ShouldSerializeEndCharacters() => EndCharacters is not null;
  public bool ShouldSerializeHanging() => Hanging is not null;
  public bool ShouldSerializeHangingChars() => HangingChars is not null;
  public bool ShouldSerializeFirstLine() => FirstLine is not null;
  public bool ShouldSerializeFirstLineChars() => FirstLineChars is not null;
}
