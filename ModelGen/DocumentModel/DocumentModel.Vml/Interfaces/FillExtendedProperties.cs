namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public interface FillExtendedProperties // : System.Boolean
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillKind? Type { get ; set; }
  
}
