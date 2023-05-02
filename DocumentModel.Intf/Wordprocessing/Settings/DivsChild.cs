namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Child div Elements Contained within Current div.
/// </summary>
public class DivsChild: ModelElement
{
  public Div? Div { get; set; }
}