namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnectortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoConnectorType))]
public enum ConnectorType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoConnectorType.msoConnectorTypeMixed))]
  TypeMixed = -2,
  /// <summary>
  /// Straight line connector.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoConnectorType.msoConnectorStraight))]
  Straight = 1,
  /// <summary>
  /// Elbow connector.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoConnectorType.msoConnectorElbow))]
  Elbow = 2,
  /// <summary>
  /// Curved connector.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoConnectorType.msoConnectorCurve))]
  Curve = 3
}
