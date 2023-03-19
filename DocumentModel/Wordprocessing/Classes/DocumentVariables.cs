namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Variables.
/// </summary>
public class DocumentVariables: ModelElement
{
  public Collection<DocumentVariable>? Items { get; set; }
}