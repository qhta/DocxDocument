namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
public enum MsoConnectorType
{
  /// <summary>
  /// Specifies a type of connector.
  /// </summary>
  TypeMixed = -2,
  /// <summary>
  /// Straight line connector.
  /// </summary>
  Straight = 1,
  /// <summary>
  /// Elbow connector.
  /// </summary>
  Elbow = 2,
  /// <summary>
  /// Curved connector.
  /// </summary>
  Curve = 3
}
