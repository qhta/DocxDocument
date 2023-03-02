namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Connection List.
/// </summary>
public record ConnectionList
{
  public Collection<Connection>? Connections { get; set; }
}