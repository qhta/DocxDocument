namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoclipboardformat?view=office-pia` for Office interop details.
/// </remarks>
public enum ClipboardFormat
{
  /// <summary>
  /// No description is available.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  Native = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  HTML = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  RTF = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  PlainText = 4
}
