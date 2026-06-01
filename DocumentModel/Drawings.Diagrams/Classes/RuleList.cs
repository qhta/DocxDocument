namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Rule IList.
/// </summary>
public class RuleList: ModelElement
{
  public Collection<Rule>? Rules { get; set; }
}
