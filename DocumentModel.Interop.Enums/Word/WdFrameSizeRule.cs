namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets the rule used to determine the height or width of a frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesizerule?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFrameSizeRule
{
  /// <summary>
  /// Specifies how Word interprets the rule used to determine the height or width of a frame.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Specifies how Word interprets the rule used to determine the height or width of a frame.
  /// </summary>
  AtLeast = 1,
  /// <summary>
  /// Specifies how Word interprets the rule used to determine the height or width of a frame.
  /// </summary>
  Exact = 2
}
