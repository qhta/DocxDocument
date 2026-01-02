namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Connection List.
/// </summary>
public class ConnectionList: ModelElement
{
  public Collection<Connection>? Connections { get; set; }
}