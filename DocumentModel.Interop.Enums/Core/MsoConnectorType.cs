namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnectortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoConnectorType")]
public enum ConnectorType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoConnectorTypeMixed")]
  TypeMixed = -2,
  /// <summary>
  /// Straight line connector.
  /// </summary>
  [InteropEnumValue("msoConnectorStraight")]
  Straight = 1,
  /// <summary>
  /// Elbow connector.
  /// </summary>
  [InteropEnumValue("msoConnectorElbow")]
  Elbow = 2,
  /// <summary>
  /// Curved connector.
  /// </summary>
  [InteropEnumValue("msoConnectorCurve")]
  Curve = 3
}
