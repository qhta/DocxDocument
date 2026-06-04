
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies type of diagram node.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramnodetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoDiagramNodeType")]
public enum DiagramNodeType
{
  /// <summary>
  /// Diagram node is a subordinate of its parent.
  /// </summary>
  [InteropEnumValue("msoDiagramNode")]
  Node = 1,
  /// <summary>
  /// Diagram node is an assistant to its parent.
  /// </summary>
  [InteropEnumValue("msoDiagramAssistant")]
  Assistant
}
