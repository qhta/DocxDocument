namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule Set.
/// </summary>
public partial class Rules
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public DM.ElementCollection<Rule>? Items { get; set; }
  
}
