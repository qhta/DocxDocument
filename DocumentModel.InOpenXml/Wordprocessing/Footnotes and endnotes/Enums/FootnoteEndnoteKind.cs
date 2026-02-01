namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FootnoteEndnoteValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FootnoteEndnoteValues))]
public enum FootnoteEndnoteKind
{
  /// <summary>
  ///   Normal Footnote/Endnote.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnoteEndnoteValues.Normal))]
  Normal,
  /// <summary>
  ///   Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnoteEndnoteValues.Separator))]
  Separator,
  /// <summary>
  ///   Continuation Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnoteEndnoteValues.ContinuationSeparator))]
  ContinuationSeparator,
  /// <summary>
  ///   Continuation Notice Separator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnoteEndnoteValues.ContinuationNotice))]
  ContinuationNotice
}