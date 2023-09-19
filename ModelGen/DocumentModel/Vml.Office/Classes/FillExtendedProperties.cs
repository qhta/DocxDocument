namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
public partial class FillExtendedProperties
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Fill Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.Office.FillValues? Type { get; set; }
  
}
