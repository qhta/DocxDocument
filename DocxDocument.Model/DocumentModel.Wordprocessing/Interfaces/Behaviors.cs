namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public partial interface Behaviors
{
  public DocumentModel.Wordprocessing.DocPartBehaviorKind? Behavior { get; set; }
  
}
