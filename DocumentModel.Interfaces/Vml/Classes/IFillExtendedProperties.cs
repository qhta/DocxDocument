namespace DocumentModel.Vml;

/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
public interface IFillExtendedProperties: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Fill Type
  /// </summary>
  public FillTypeKind? Type { get; set; }
}