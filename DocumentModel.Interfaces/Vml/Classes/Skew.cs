namespace DocumentModel.Vml;

/// <summary>
///   Skew Transform.
/// </summary>
public class Skew: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Skew ID
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  public bool? On { get; set; }
  /// <summary>
  ///   Skew Offset
  /// </summary>
  public string? Offset { get; set; }
  /// <summary>
  ///   Skew Origin
  /// </summary>
  public string? Origin { get; set; }
  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  public string? Matrix { get; set; }
}