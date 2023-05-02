namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connection List.
/// </summary>
public class ConnectionList: ModelElement
{
  public Collection<Connection>? Connections { get; set; }
}