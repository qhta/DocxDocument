namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies whether the gutter style should conform to left-to-right text flow or right-to-left text flow.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyleold?view=office-pia` for Office interop details.
/// </remarks>
public enum GutterStyleOld
{
  /// <summary>
  /// Bidirectional gutter should be used to conform to right-to-left text flow.
  /// </summary>
  Bidi = 2,
  /// <summary>
  /// Latin gutter should be used to conform to left-to-right text flow.
  /// </summary>
  Latin = -10
}
