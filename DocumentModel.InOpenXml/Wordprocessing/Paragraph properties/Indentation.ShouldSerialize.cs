namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Indentation
{
  public bool ShouldSerializeLeft() => !String.IsNullOrEmpty(Left);
  public bool ShouldSerializeStart() => !String.IsNullOrEmpty(Start);
  public bool ShouldSerializeLeftChars() => LeftChars is not null && ShouldSerialize(LeftChars);
  public bool ShouldSerializeStartCharacters() => StartCharacters is not null && ShouldSerialize(StartCharacters);
  public bool ShouldSerializeRight() => !String.IsNullOrEmpty(Right);
  public bool ShouldSerializeEnd() => !String.IsNullOrEmpty(End);
  public bool ShouldSerializeRightChars() => RightChars is not null && ShouldSerialize(RightChars);
  public bool ShouldSerializeEndCharacters() => EndCharacters is not null && ShouldSerialize(EndCharacters);
  public bool ShouldSerializeHanging() => !String.IsNullOrEmpty(Hanging);
  public bool ShouldSerializeHangingChars() => HangingChars is not null && ShouldSerialize(HangingChars);
  public bool ShouldSerializeFirstLine() => !String.IsNullOrEmpty(FirstLine);
  public bool ShouldSerializeFirstLineChars() => FirstLineChars is not null && ShouldSerialize(FirstLineChars);
}
