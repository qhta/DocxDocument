namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of phonetic text that is added to the specified range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdphoneticguidealignmenttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPhoneticGuideAlignmentType")]
public enum PhoneticGuideAlignmentType
{
  /// <summary>
  /// Microsoft Word centers phonetic text over the specified range. This is the default value.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentCenter")]
  Center = 0,
  /// <summary>
  /// Word adjusts the inside and outside spacing of the phonetic text in a 0:1:0 ratio.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentZeroOneZero")]
  ZeroOneZero = 1,
  /// <summary>
  /// Word adjusts the inside and outside spacing of the phonetic text in a 1:2:1 ratio.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentOneTwoOne")]
  OneTwoOne = 2,
  /// <summary>
  /// Word left-aligns phonetic text with the specified range.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentLeft")]
  Left = 3,
  /// <summary>
  /// Word right-aligns phonetic text with the specified range.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentRight")]
  Right = 4,
  /// <summary>
  /// Word aligns the phonetic text on the right side of vertical text.
  /// </summary>
  [WordInteropEnumValue("wdPhoneticGuideAlignmentRightVertical")]
  RightVertical = 5
}
