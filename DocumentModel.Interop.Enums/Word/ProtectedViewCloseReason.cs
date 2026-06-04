namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the Protected View window was closed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprotectedviewclosereason?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdProtectedViewCloseReason")]
public enum ProtectedViewCloseReason
{
  /// <summary>
  /// The window was closed normally.
  /// </summary>
  [WordInteropEnumValue("wdProtectedViewCloseNormal")]
  Normal = 0,
  /// <summary>
  /// The window was closed when the user clicked the Enable Editing or Edit Anyway button while in Protected View.
  /// </summary>
  [WordInteropEnumValue("wdProtectedViewCloseEdit")]
  Edit = 1,
  /// <summary>
  /// The window was closed because the application shut it down forcefully or it stopped responding.
  /// </summary>
  [WordInteropEnumValue("wdProtectedViewCloseForced")]
  Forced = 2
}
