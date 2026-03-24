namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotristate?view=office-pia` for Office interop details.
/// </remarks>
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
