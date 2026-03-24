namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the Protected View window was closed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprotectedviewclosereason?view=office-pia` for Office interop details.
/// </remarks>
public enum WdProtectedViewCloseReason
{
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Normal = 0,
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Edit = 1,
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Forced = 2
}
