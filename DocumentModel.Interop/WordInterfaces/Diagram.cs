namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram?view=word-pia"/>
public partial interface Diagram : InteropObject
{
  /// <summary>
  /// The nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.nodes?view=word-pia"/>
  public DiagramNodes Nodes { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.type?view=word-pia"/>
  public Core.MsoDiagramType Type { get; }

  /// <summary>
  /// The auto layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.autolayout?view=word-pia"/>
  public Core.MsoTriState AutoLayout { get; set; }

  /// <summary>
  /// The reverse.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.reverse?view=word-pia"/>
  public Core.MsoTriState Reverse { get; set; }

  /// <summary>
  /// The auto format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.autoformat?view=word-pia"/>
  public Core.MsoTriState AutoFormat { get; set; }
}
