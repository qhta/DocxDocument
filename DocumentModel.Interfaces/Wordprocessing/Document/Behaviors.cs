namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public interface Behaviors: IModelElement
{
  public DocPartBehaviorKind? Behavior { get; set; }
}