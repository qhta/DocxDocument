namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public class Behaviors: ModelElement
{
  public DocPartBehaviorKind? Behavior { get; set; }
}