namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotristate?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTriState")]
public enum TriState
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoTrue")]
  True = -1,
  /// <summary>
  /// False.
  /// </summary>
  [InteropEnumValue("msoFalse")]
  False = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoCTrue")]
  CTrue = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoTriStateToggle")]
  TriStateToggle = -3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoTriStateMixed")]
  TriStateMixed = -2
}
