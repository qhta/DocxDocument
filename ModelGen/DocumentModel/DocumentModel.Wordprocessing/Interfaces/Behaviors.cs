namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public interface Behaviors // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DocPartBehaviorKind>? Behaviors { get ; set; }
  
}
