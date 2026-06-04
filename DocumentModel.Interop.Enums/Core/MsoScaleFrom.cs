namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which part of the shape retains its position when the shape is scaled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscalefrom?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoScaleFrom))]
public enum ScaleFrom
{
  /// <summary>
  /// Shape's top left corner retains its position.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScaleFrom.msoScaleFromTopLeft))]
  TopLeft,
  /// <summary>
  /// Shape's midpoint retains its position.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScaleFrom.msoScaleFromMiddle))]
  Middle,
  /// <summary>
  /// Shape's bottom right corner retains its position.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScaleFrom.msoScaleFromBottomRight))]
  BottomRight
}
