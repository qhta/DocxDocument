namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of connector.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnectortype?view=office-pia` for Office interop details.
/// </remarks>
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
