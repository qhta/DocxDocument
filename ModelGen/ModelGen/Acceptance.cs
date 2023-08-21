namespace ModelGenApp.Helpers;

/// <summary>
/// Enumeration type to visualize IsAccepted/IsRejected property.
/// </summary>
public enum Acceptance
{
  /// <summary>
  /// No IsAccepted and no IsRejected set,
  /// </summary>
  unspecified,
  /// <summary>
  /// IsAccepted set,
  /// </summary>
  accepted = 1,
  /// <summary>
  /// IsRejected set
  /// </summary>
  rejected = 2,
  /// <summary>
  /// IsAccepted set and IsRejected set,
  /// </summary>
  invalid = 3,
}
