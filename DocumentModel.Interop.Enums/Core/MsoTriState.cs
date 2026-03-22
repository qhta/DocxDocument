namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
public enum MsoTriState
{
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  msoTrue = -1,
  /// <summary>
  /// False.
  /// </summary>
  msoFalse = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  msoCTrue = 1,
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  msoTriStateToggle = -3,
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  msoTriStateMixed = -2
}
