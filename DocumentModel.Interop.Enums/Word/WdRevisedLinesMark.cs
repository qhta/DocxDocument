namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where revisions are displayed when change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisedlinesmark?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRevisedLinesMark
{
  /// <summary>
  /// Not displayed.
  /// </summary>
  None = 0,
  /// <summary>
  /// In the left border.
  /// </summary>
  LeftBorder = 1,
  /// <summary>
  /// In the right border.
  /// </summary>
  RightBorder = 2,
  /// <summary>
  /// Outside the border.
  /// </summary>
  OutsideBorder = 3
}
