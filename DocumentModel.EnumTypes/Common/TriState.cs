namespace DocumentModel;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotristate?view=office-pia` for Office interop details.
/// </remarks>
public enum TriState
{
  /// <summary>
  /// Not supported.
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
  /// Not supported.
  /// </summary>
  TriStateToggle = -3,
  /// <summary>
  /// Not supported.
  /// </summary>
  TriStateMixed = -2
}

