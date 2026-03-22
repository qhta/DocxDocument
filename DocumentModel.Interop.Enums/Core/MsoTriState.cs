namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
public enum MsoTriState
{
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  True = -1,
  /// <summary>
  /// False.
  /// </summary>
  False = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  CTrue = 1,
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  TriStateToggle = -3,
  /// <summary>
  /// Specifies a tri-state Boolean value.
  /// </summary>
  TriStateMixed = -2
}
