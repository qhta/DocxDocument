namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Variables.
/// </summary>
public record DocumentVariables
{
  public Collection<DocumentVariable>? Items { get; set; }
}