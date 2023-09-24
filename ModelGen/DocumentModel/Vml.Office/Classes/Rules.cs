namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule Set.
/// </summary>
public partial class Rules
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public ElementCollection<Rule>? Items { get; set; }
  
}
