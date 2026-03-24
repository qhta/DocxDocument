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
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  MarkupRectangleArea = 8,
  /// <summary>
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  ReadingModeNavigation = 9,
  /// <summary>
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  MarkupRectangleMoveMatch = 10,
  /// <summary>
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  ReadingModePanningArea = 11,
  /// <summary>
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  MailNavArea = 12,
  /// <summary>
  /// Specifies the type of rectangle and the information it contains.
  /// </summary>
  DocumentControlRectangle = 13
}
