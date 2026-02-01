namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies paragraph justification options for text alignment in WordprocessingML documents.
/// This enumeration provides values for left, center, right, start, end, justified, Kashida, distributed, and other alignment modes, supporting advanced formatting and layout control for paragraphs and text blocks within document content.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.JustificationValues))]
public enum JustificationKind
{
  /// <summary>
  /// Align left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Left))]
  Left,
  /// <summary>
  /// Align start (logical start of the text direction).
  /// </summary>
  Start,
  /// <summary>
  /// Align center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Center))]
  Center,
  /// <summary>
  /// Align right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.JustificationValues.Right))]
  Right,
  /// <summary>
  /// Align end (logical end of the text direction).
  /// </summary>
  End,
  /// <summary>
  /// Justified alignment.
  /// </summary>
  Both,
  /// <summary>
  /// Medium Kashida length (Arabic script justification).
  /// </summary>
  MediumKashida,
  /// <summary>
  /// Distribute all characters equally.
  /// </summary>
  Distribute,
  /// <summary>
  /// Align to list tab.
  /// </summary>
  NumTab,
  /// <summary>
  /// Widest Kashida length (Arabic script justification).
  /// </summary>
  HighKashida,
  /// <summary>
  /// Low Kashida length (Arabic script justification).
  /// </summary>
  LowKashida,
  /// <summary>
  /// Thai language justification.
  /// </summary>
  ThaiDistribute
}