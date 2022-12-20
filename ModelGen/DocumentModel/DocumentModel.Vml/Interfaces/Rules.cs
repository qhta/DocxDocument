namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public partial interface Rules
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public Collection<DocumentModel.Vml.Rule>? Items { get; set; }
  
}
