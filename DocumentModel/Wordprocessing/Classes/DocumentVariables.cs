namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Variables.
/// </summary>
public class DocumentVariables: ModelElement
{
  public Collection<DocumentVariable>? Items { get; set; }
}