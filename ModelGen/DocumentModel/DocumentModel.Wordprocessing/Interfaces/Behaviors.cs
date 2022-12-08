namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public interface Behaviors
{
  public Collection<DocPartBehaviorKind>? Items { get ; set; }
  
}
