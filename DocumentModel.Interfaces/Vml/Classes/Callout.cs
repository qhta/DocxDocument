namespace DocumentModel.Vml;

/// <summary>
///   Defines the Callout Class.
/// </summary>
public class Callout: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Callout toggle
  /// </summary>
  public bool? On { get; set; }
  /// <summary>
  ///   Callout type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   Callout gap
  /// </summary>
  public string? Gap { get; set; }
  /// <summary>
  ///   Callout angle
  /// </summary>
  public AngleKind? Angle { get; set; }
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  public bool? DropAuto { get; set; }
  /// <summary>
  ///   Callout drop position
  /// </summary>
  public string? Drop { get; set; }
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  public string? Distance { get; set; }
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  public bool? LengthSpecified { get; set; }
  /// <summary>
  ///   Callout length
  /// </summary>
  public string? Length { get; set; }
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  public bool? AccentBar { get; set; }
  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  public bool? TextBorder { get; set; }
  /// <summary>
  ///   Callout flip x
  /// </summary>
  public bool? MinusX { get; set; }
  /// <summary>
  ///   Callout flip y
  /// </summary>
  public bool? MinusY { get; set; }
}