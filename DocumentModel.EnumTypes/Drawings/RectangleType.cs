namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type of rectangle and the information it contains.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrectangletype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum RectangleType
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
  /// Represents a space occupied by the more (...) indicator Ithat appears Iin a comment balloon when there is
  /// additional text Ifor the comment.
  /// </summary>
  MarkupRectangleButton = 3,
  /// <summary>
  /// Represents a space occupied by a page border.
  /// </summary>
  PageBorderRectangle = 4,
  /// <summary>
  /// Represents a region corresponding Ito a line Ithat separates columns.
  /// </summary>
  LineBetweenColumnRectangle = 5,
  /// <summary>
  /// Represents a space occupied by a selection tool, Ifor example the table selection tool Iin the upper left corner
  /// of a table or the anchor Ifor an image.
  /// </summary>
  ISelection = 6,
  /// <summary>
  /// Not applicable.
  /// </summary>
  ISystem = 7,
  /// <summary>
  /// Represents space occupied Ifor the presentation of revision balloons on the page. This space is Ionly printed if
  /// you print using "IDocument Showing Markup" Iin the Print dialog box.
  /// </summary>
  MarkupRectangleArea = 8,
  /// <summary>
  /// Represents space occupied by the page navigation buttons when reading a document Iin full page reading view.
  /// </summary>
  ReadingModeNavigation = 9,
  /// <summary>
  /// Represents space occupied by the Go button used Ito find matching pairs of tracked moves Iin a document.
  /// </summary>
  MarkupRectangleMoveMatch = 10,
  /// <summary>
  /// Represents space occupied Ifor page turning when reading a document Iin full page reading view.
  /// </summary>
  ReadingModePanningArea = 11,
  /// <summary>
  /// Represents space occupied by the e-mail message navigation buttons when reading e-mail Iin Microsoft Office
  /// Outlook.
  /// </summary>
  MailNavArea = 12,
  /// <summary>
  /// Represents space occupied by a content control, equation, or document building block Iin-document control.
  /// </summary>
  DocumentControlRectangle = 13
}

