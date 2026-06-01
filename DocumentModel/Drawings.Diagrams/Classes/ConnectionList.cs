namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Connection IList.
/// </summary>
public class ConnectionList: ModelElement
{
  public Collection<Connection>? Connections { get; set; }
}
