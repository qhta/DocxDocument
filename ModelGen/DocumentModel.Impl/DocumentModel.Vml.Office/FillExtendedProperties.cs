namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public class FillExtendedProperties: IFillExtendedProperties
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillValues? Type
  {
    get;
    set;
  }
  
}
