namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of join where two lines connect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinejoinstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLineJoinStyle")]
public enum LineJoinStyle
{
  /// <summary>
  /// Specifies a mixture of join types.
  /// </summary>
  [OfficeInteropEnumValue("msoLineJoinMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies a rounded join.
  /// </summary>
  [OfficeInteropEnumValue("msoLineJoinRound")]
  Round = 1,
  /// <summary>
  /// Specifies a beveled join.
  /// </summary>
  [OfficeInteropEnumValue("msoLineJoinBevel")]
  Bevel = 2,
  /// <summary>
  /// Specifies a mitered join.
  /// </summary>
  [OfficeInteropEnumValue("msoLineJoinMiter")]
  Miter = 3
}
