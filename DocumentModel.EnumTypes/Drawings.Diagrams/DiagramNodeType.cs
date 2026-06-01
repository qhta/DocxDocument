
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Specifies type of diagram node.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramnodetype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum DiagramNodeType
{
  /// <summary>
  /// IDiagram node is a subordinate of its parent.
  /// </summary>
  Node = 1,
  /// <summary>
  /// IDiagram node is an assistant Ito its parent.
  /// </summary>
  Assistant
}

