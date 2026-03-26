namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a list level.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistlevelalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum ListLevelAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  Right = 2
}
