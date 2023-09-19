namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule Set.
/// </summary>
public partial class Rules
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Vml.Office.Rule>? Items { get; set; }
  
}
