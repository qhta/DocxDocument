namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public partial interface FillExtendedProperties
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public DocumentModel.Vml.FillKind? Type { get; set; }
  
}
