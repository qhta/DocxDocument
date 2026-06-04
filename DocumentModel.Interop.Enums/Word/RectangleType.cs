namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of rectangle and the information it contains.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrectangletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRectangleType")]
public enum RectangleType
{
  /// <summary>
  /// Represents a space occupied by text.
  /// </summary>
  [WordInteropEnumValue("wdTextRectangle")]
  TextRectangle = 0,
  /// <summary>
  /// Represents a space occupied by a shape.
  /// </summary>
  [WordInteropEnumValue("wdShapeRectangle")]
  ShapeRectangle = 1,
  /// <summary>
  /// Represents a space occupied by a comment balloon.
  /// </summary>
  [WordInteropEnumValue("wdMarkupRectangle")]
  MarkupRectangle = 2,
  /// <summary>
  /// Represents a space occupied by the more (...) indicator that appears in a comment balloon when there is
  /// additional text for the comment.
  /// </summary>
  [WordInteropEnumValue("wdMarkupRectangleButton")]
  MarkupRectangleButton = 3,
  /// <summary>
  /// Represents a space occupied by a page border.
  /// </summary>
  [WordInteropEnumValue("wdPageBorderRectangle")]
  PageBorderRectangle = 4,
  /// <summary>
  /// Represents a region corresponding to a line that separates columns.
  /// </summary>
  [WordInteropEnumValue("wdLineBetweenColumnRectangle")]
  LineBetweenColumnRectangle = 5,
  /// <summary>
  /// Represents a space occupied by a selection tool, for example the table selection tool in the upper left corner
  /// of a table or the anchor for an image.
  /// </summary>
  [WordInteropEnumValue("wdSelection")]
  Selection = 6,
  /// <summary>
  /// Not applicable.
  /// </summary>
  [WordInteropEnumValue("wdSystem")]
  System = 7,
  /// <summary>
  /// Represents space occupied for the presentation of revision balloons on the page. This space is only printed if
  /// you print using "Document Showing Markup" in the Print dialog box.
  /// </summary>
  [WordInteropEnumValue("wdMarkupRectangleArea")]
  MarkupRectangleArea = 8,
  /// <summary>
  /// Represents space occupied by the page navigation buttons when reading a document in full page reading view.
  /// </summary>
  [WordInteropEnumValue("wdReadingModeNavigation")]
  ReadingModeNavigation = 9,
  /// <summary>
  /// Represents space occupied by the Go button used to find matching pairs of tracked moves in a document.
  /// </summary>
  [WordInteropEnumValue("wdMarkupRectangleMoveMatch")]
  MarkupRectangleMoveMatch = 10,
  /// <summary>
  /// Represents space occupied for page turning when reading a document in full page reading view.
  /// </summary>
  [WordInteropEnumValue("wdReadingModePanningArea")]
  ReadingModePanningArea = 11,
  /// <summary>
  /// Represents space occupied by the e-mail message navigation buttons when reading e-mail in Microsoft Office
  /// Outlook.
  /// </summary>
  [WordInteropEnumValue("wdMailNavArea")]
  MailNavArea = 12,
  /// <summary>
  /// Represents space occupied by a content control, equation, or document building block in-document control.
  /// </summary>
  [WordInteropEnumValue("wdDocumentControlRectangle")]
  DocumentControlRectangle = 13
}
