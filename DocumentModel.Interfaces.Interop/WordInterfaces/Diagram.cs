namespace DocumentModel.Interop;

/// <summary>
/// Represents a single diagram in a document.
/// </summary>
public partial interface Diagram : InteropObject
{
  /// <summary>
  /// The nodes.
  /// </summary>
  public DiagramNodes Nodes { get; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoDiagramType Type { get; }

  /// <summary>
  /// The auto layout.
  /// </summary>
  //public Core.MsoTriState AutoLayout { get; set; }

  /// <summary>
  /// The reverse.
  /// </summary>
  //public Core.MsoTriState Reverse { get; set; }

  /// <summary>
  /// The auto format.
  /// </summary>
  //public Core.MsoTriState AutoFormat { get; set; }
}
