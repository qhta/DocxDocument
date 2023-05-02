namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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