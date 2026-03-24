namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the option for automatically saving document versions.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautoversions?view=office-pia` for Office interop details.
/// </remarks>
public enum WdAutoVersions
{
  /// <summary>
  /// Specifies the state of the option for automatically saving document versions.
  /// </summary>
  ff = 0,
  /// <summary>
  /// Specifies the state of the option for automatically saving document versions.
  /// </summary>
  nClose = 1
}
