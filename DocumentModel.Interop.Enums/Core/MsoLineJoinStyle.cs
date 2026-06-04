namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of join where two lines connect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinejoinstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLineJoinStyle))]
public enum LineJoinStyle
{
  /// <summary>
  /// Specifies a mixture of join types.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineJoinStyle.msoLineJoinMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies a rounded join.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineJoinStyle.msoLineJoinRound))]
  Round = 1,
  /// <summary>
  /// Specifies a beveled join.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineJoinStyle.msoLineJoinBevel))]
  Bevel = 2,
  /// <summary>
  /// Specifies a mitered join.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineJoinStyle.msoLineJoinMiter))]
  Miter = 3
}
