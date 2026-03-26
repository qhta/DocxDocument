namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstyletype?view=office-pia` for Office interop details.
/// </remarks>
public enum StyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  Paragraph = 1,
  /// <summary>
  /// Body character style.
  /// </summary>
  Character = 2,
  /// <summary>
  /// Table style.
  /// </summary>
  Table = 3,
  /// <summary>
  /// List style.
  /// </summary>
  List = 4,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  ParagraphOnly = 5,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  Linked = 6
}
