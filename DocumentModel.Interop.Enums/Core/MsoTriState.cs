namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotristate?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTriState")]
public enum TriState
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoTrue")]
  True = -1,
  /// <summary>
  /// False.
  /// </summary>
  [OfficeInteropEnumValue("msoFalse")]
  False = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoCTrue")]
  CTrue = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoTriStateToggle")]
  TriStateToggle = -3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoTriStateMixed")]
  TriStateMixed = -2
}
