namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of rectangle and the information it contains.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrectangletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRectangleType))]
public enum RectangleType
{
  /// <summary>
  /// Represents a space occupied by text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdTextRectangle))]
  TextRectangle = 0,
  /// <summary>
  /// Represents a space occupied by a shape.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdShapeRectangle))]
  ShapeRectangle = 1,
  /// <summary>
  /// Represents a space occupied by a comment balloon.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdMarkupRectangle))]
  MarkupRectangle = 2,
  /// <summary>
  /// Represents a space occupied by the more (...) indicator that appears in a comment balloon when there is
  /// additional text for the comment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdMarkupRectangleButton))]
  MarkupRectangleButton = 3,
  /// <summary>
  /// Represents a space occupied by a page border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdPageBorderRectangle))]
  PageBorderRectangle = 4,
  /// <summary>
  /// Represents a region corresponding to a line that separates columns.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdLineBetweenColumnRectangle))]
  LineBetweenColumnRectangle = 5,
  /// <summary>
  /// Represents a space occupied by a selection tool, for example the table selection tool in the upper left corner
  /// of a table or the anchor for an image.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdSelection))]
  Selection = 6,
  /// <summary>
  /// Not applicable.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdSystem))]
  System = 7,
  /// <summary>
  /// Represents space occupied for the presentation of revision balloons on the page. This space is only printed if
  /// you print using "Document Showing Markup" in the Print dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdMarkupRectangleArea))]
  MarkupRectangleArea = 8,
  /// <summary>
  /// Represents space occupied by the page navigation buttons when reading a document in full page reading view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdReadingModeNavigation))]
  ReadingModeNavigation = 9,
  /// <summary>
  /// Represents space occupied by the Go button used to find matching pairs of tracked moves in a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdMarkupRectangleMoveMatch))]
  MarkupRectangleMoveMatch = 10,
  /// <summary>
  /// Represents space occupied for page turning when reading a document in full page reading view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdReadingModePanningArea))]
  ReadingModePanningArea = 11,
  /// <summary>
  /// Represents space occupied by the e-mail message navigation buttons when reading e-mail in Microsoft Office
  /// Outlook.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdMailNavArea))]
  MailNavArea = 12,
  /// <summary>
  /// Represents space occupied by a content control, equation, or document building block in-document control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRectangleType.wdDocumentControlRectangle))]
  DocumentControlRectangle = 13
}
