namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Rule List.
/// </summary>
public class RuleList: ModelElement
{
  public Collection<Rule>? Rules { get; set; }
}