namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of rectangle and the information it contains.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrectangletype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRectangleType
{
  /// <summary>
  /// Represents a space occupied by text.
  /// </summary>
  TextRectangle = 0,
  /// <summary>
  /// Represents a space occupied by a shape.
  /// </summary>
  ShapeRectangle = 1,
  /// <summary>
  /// Represents a space occupied by a comment balloon.
  /// </summary>
  MarkupRectangle = 2,
  /// <summary>
  /// Represents a space occupied by the more (...) indicator that appears in a comment balloon when there is
  /// additional text for the comment.
  /// </summary>
  MarkupRectangleButton = 3,
  /// <summary>
  /// Represents a space occupied by a page border.
  /// </summary>
  PageBorderRectangle = 4,
  /// <summary>
  /// Represents a region corresponding to a line that separates columns.
  /// </summary>
  LineBetweenColumnRectangle = 5,
  /// <summary>
  /// Represents a space occupied by a selection tool, for example the table selection tool in the upper left corner
  /// of a table or the anchor for an image.
  /// </summary>
  Selection = 6,
  /// <summary>
  /// Not applicable.
  /// </summary>
  System = 7,
  /// <summary>
  /// Represents space occupied for the presentation of revision balloons on the page. This space is only printed if
  /// you print using "Document Showing Markup" in the Print dialog box.
  /// </summary>
  MarkupRectangleArea = 8,
  /// <summary>
  /// Represents space occupied by the page navigation buttons when reading a document in full page reading view.
  /// </summary>
  ReadingModeNavigation = 9,
  /// <summary>
  /// Represents space occupied by the Go button used to find matching pairs of tracked moves in a document.
  /// </summary>
  MarkupRectangleMoveMatch = 10,
  /// <summary>
  /// Represents space occupied for page turning when reading a document in full page reading view.
  /// </summary>
  ReadingModePanningArea = 11,
  /// <summary>
  /// Represents space occupied by the e-mail message navigation buttons when reading e-mail in Microsoft Office
  /// Outlook.
  /// </summary>
  MailNavArea = 12,
  /// <summary>
  /// Represents space occupied by a content control, equation, or document building block in-document control.
  /// </summary>
  DocumentControlRectangle = 13
}
