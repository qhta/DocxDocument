namespace DocumentModel.Vml;

/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
public class FillExtendedProperties: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Fill Type
  /// </summary>
  public FillKind? Type { get; set; }
}