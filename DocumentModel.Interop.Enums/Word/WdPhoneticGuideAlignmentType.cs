namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of phonetic text that is added to the specified range.
/// </summary>
public enum WdPhoneticGuideAlignmentType
{
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  Center = 0,
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  ZeroOneZero = 1,
  /// <summary>
  /// Word adjusts the inside and outside spacing of the phonetic text in a 1:2:1 ratio.
  /// </summary>
  OneTwoOne = 2,
  /// <summary>
  /// Word left-aligns phonetic text with the specified range. wdPhoneticGuideAlignmentRight4 Word right-aligns
  /// phonetic text with the specified range.
  /// </summary>
  Left = 3,
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  Right = 4,
  /// <summary>
  /// Word aligns the phonetic text on the right side of vertical text.
  /// </summary>
  RightVertical = 5
}
