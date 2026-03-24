namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the Protected View window was closed.
/// </summary>
public enum WdProtectedViewCloseReason
{
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Normal = unchecked((int)0),
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Edit = unchecked((int)1),
  /// <summary>
  /// Specifies how the Protected View window was closed.
  /// </summary>
  Forced = unchecked((int)2)
}
