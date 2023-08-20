namespace ModelGenApp.Helpers;

/// <summary>
/// Enumeration type to visualize IsAccepted/IsRejected property.
/// </summary>
public enum Acceptance
{
  /// <summary>
  /// No IsAccepted and no IsRejected set,
  /// </summary>
  Unspecified,
  /// <summary>
  /// IsAccepted set,
  /// </summary>
  Accepted = 1,
  /// <summary>
  /// IsRejected set
  /// </summary>
  Rejected = 2,
  /// <summary>
  /// IsAccepted set and IsRejected set,
  /// </summary>
  Invalid = 3,
}
