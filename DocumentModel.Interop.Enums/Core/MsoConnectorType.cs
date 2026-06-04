namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnectortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoConnectorType")]
public enum ConnectorType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoConnectorTypeMixed")]
  TypeMixed = -2,
  /// <summary>
  /// Straight line connector.
  /// </summary>
  [OfficeInteropEnumValue("msoConnectorStraight")]
  Straight = 1,
  /// <summary>
  /// Elbow connector.
  /// </summary>
  [OfficeInteropEnumValue("msoConnectorElbow")]
  Elbow = 2,
  /// <summary>
  /// Curved connector.
  /// </summary>
  [OfficeInteropEnumValue("msoConnectorCurve")]
  Curve = 3
}
