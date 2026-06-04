namespace DocumentModel.Drawings.Wordprocessing;
/// <summary>
/// Specifies the reference point for determining the horizontal size of a drawing element relative to another element in a Wordprocessing document.
/// This enumeration provides options for margins, page boundaries, and other layout anchors used in relative sizing calculations.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues))]
public enum SizeRelativeHorizontally
{
  /// <summary>
  /// The entire margin area is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.Margin))]
  Margin,
  /// <summary>
  /// The page boundary is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.Page))]
  Page,
  /// <summary>
  /// The left margin is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.LeftMargin))]
  LeftMargin,
  /// <summary>
  /// The right margin is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.RightMargin))]
  RightMargin,
  /// <summary>
  /// The inside margin (typically for facing pages) is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.InsideMargin))]
  InsideMargin,
  /// <summary>
  /// The outside margin (typically for facing pages) is used as the reference for horizontal sizing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues.OutsideMargin))]
  OutsideMargin
}
