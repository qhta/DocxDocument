namespace DocumentModel.Vml;
/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
public partial class FillExtendedProperties : ModelElement<DXVO.FillExtendedProperties>
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