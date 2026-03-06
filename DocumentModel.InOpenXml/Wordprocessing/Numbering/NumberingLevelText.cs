namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the textual content displayed for a paragraph at a given numbering level in a WordprocessingML document.
///   This class provides properties for the literal text to be repeated in each instance of the numbering level, supporting the use of percent symbol (%) followed by a number to indicate the one-based index of the number to be used at this level. Numbers for higher levels are ignored, and the % syntax increments for each subsequent paragraph until a restart occurs.
/// </summary>
public partial class NumberingLevelText: ModelElement<DXW.LevelText>
{
  /// <summary>
  ///   Textual content for the numbering level, with %x replaced by the appropriate number for the level.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LevelText.Val))]
  public string? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }

  private string? _Text;

  /// <summary>
  ///   Indicates whether the level text is a null character.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.LevelText.Null))]
  public Boolean? IsNull { get => _IsNull; set => UpdateField(ref _IsNull, value, nameof(IsNull)); }

  private Boolean? _IsNull;
}