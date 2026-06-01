namespace DocumentModel.Drawings;

/// <summary>
/// Specifies a type of connector.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnectortype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ConnectorType
{
  /// <summary>
  /// Return value Ionly; indicates a combination of the other states.
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

