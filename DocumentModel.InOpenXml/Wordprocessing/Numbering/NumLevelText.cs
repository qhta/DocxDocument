namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the textual content displayed for a paragraph at a given numbering level in a WordprocessingML document.
///   This interface provides properties for the literal text to be repeated in each instance of the numbering level, supporting the use of percent symbol (%) followed by a number to indicate the one-based index of the number to be used at this level. Numbers for higher levels are ignored, and the % syntax increments for each subsequent paragraph until a restart occurs.
/// </summary>
public class NumLevelText: ModelElement//<DXW.NumLevelText>
{
  /// <summary>
  ///   Textual content for the numbering level, with %x replaced by the appropriate number for the level.
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Indicates whether the level text is a null character.
  /// </summary>
  public Boolean IsNull { get; set; }
}