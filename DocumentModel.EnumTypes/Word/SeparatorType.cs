namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseparatortype?view=office-pia` for Office interop details.
/// </remarks>
public enum SeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  Hyphen = 0,
  /// <summary>
  /// A period.
  /// </summary>
  Period = 1,
  /// <summary>
  /// A colon.
  /// </summary>
  Colon = 2,
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  EmDash = 3,
  /// <summary>
  /// A standard dash.
  /// </summary>
  EnDash = 4
}
