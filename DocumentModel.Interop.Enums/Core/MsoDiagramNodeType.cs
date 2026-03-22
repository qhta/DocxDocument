
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies type of diagram node.
/// </summary>
public enum MsoDiagramNodeType
{
  /// <summary>
  /// Diagram node is a subordinate of its parent.
  /// </summary>
  msoDiagramNode = 1,
  /// <summary>
  /// Diagram node is an assistant to its parent.
  /// </summary>
  msoDiagramAssistant
}
