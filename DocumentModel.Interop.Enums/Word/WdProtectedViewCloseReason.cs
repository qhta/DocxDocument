namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the Protected View window was closed.
/// </summary>
public enum WdProtectedViewCloseReason
{
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  wdProtectedViewCloseNormal = unchecked((int)0),
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  wdProtectedViewCloseEdit = unchecked((int)1),
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  wdProtectedViewCloseForced = unchecked((int)2)
}
