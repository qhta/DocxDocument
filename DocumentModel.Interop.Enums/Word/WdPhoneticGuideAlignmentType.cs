namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of phonetic text that is added to the specified range.
/// </summary>
public enum WdPhoneticGuideAlignmentType
{
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  wdPhoneticGuideAlignmentCenter = unchecked((int)0),
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  wdPhoneticGuideAlignmentZeroOneZero = unchecked((int)1),
  /// <summary>
  /// Word adjusts the inside and outside spacing of the phonetic text in a 1:2:1 ratio.
  /// </summary>
  wdPhoneticGuideAlignmentOneTwoOne = unchecked((int)2),
  /// <summary>
  /// Word left-aligns phonetic text with the specified range. wdPhoneticGuideAlignmentRight4 Word right-aligns
  /// phonetic text with the specified range.
  /// </summary>
  wdPhoneticGuideAlignmentLeft = unchecked((int)3),
  /// <summary>
  /// Specifies the alignment of phonetic text that is added to the specified range.
  /// </summary>
  wdPhoneticGuideAlignmentRight = unchecked((int)4),
  /// <summary>
  /// Word aligns the phonetic text on the right side of vertical text.
  /// </summary>
  wdPhoneticGuideAlignmentRightVertical = unchecked((int)5)
}
