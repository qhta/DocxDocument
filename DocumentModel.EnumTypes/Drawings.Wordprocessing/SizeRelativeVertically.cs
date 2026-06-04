namespace DocumentModel.Drawings.Wordprocessing;
/// <summary>
/// Specifies the reference point for determining the vertical size of a drawing element relative to another element in a Wordprocessing document.
/// This enumeration provides options for margins, page boundaries, and other layout anchors used in relative sizing calculations.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues))]
public enum SizeRelativeVertically
{
  /// <summary>
  /// The entire margin area is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.Margin))]
  Margin,
  /// <summary>
  /// The page boundary is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.Page))]
  Page,
  /// <summary>
  /// The top margin is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.TopMargin))]
  TopMargin,
  /// <summary>
  /// The bottom margin is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.BottomMargin))]
  BottomMargin,
  /// <summary>
  /// The inside margin (typically for facing pages) is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.InsideMargin))]
  InsideMargin,
  /// <summary>
  /// The outside margin (typically for facing pages) is used as the reference for vertical sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues.OutsideMargin))]
  OutsideMargin
}
