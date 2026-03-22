namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
public enum MsoConnectorType
{
  /// <summary>
  /// Specifies a type of connector.
  /// </summary>
  msoConnectorTypeMixed = -2,
  /// <summary>
  /// Straight line connector.
  /// </summary>
  msoConnectorStraight = 1,
  /// <summary>
  /// Elbow connector.
  /// </summary>
  msoConnectorElbow = 2,
  /// <summary>
  /// Curved connector.
  /// </summary>
  msoConnectorCurve = 3
}
