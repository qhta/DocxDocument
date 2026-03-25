namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfractype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  Bar = 0,
  /// <summary>
  /// No fraction bar.
  /// </summary>
  NoBar = 1,
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  Skw = 2,
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  Lin = 3
}
