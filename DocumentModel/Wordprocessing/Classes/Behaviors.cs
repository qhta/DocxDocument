namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public record Behaviors
{
  public DocPartBehaviorKind? Behavior { get; set; }
}