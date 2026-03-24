namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of a table in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTablePosition
{
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Specifies the relative position of a table in the document.
  /// </summary>
  Outside = -999993
}
