namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram?view=word-pia"/>
public partial interface Diagram : InteropObject
{
  /// <summary>
  /// Gets the collection of nodes in the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.nodes?view=word-pia"/>
  public DiagramNodes Nodes { get; }

  /// <summary>
  /// Gets the diagram type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.type?view=word-pia"/>
  public Core.DiagramType Type { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the diagram layout is updated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.autolayout?view=word-pia"/>
  public Core.TriState AutoLayout { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the diagram is reversed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.reverse?view=word-pia"/>
  public Core.TriState Reverse { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether diagram formatting is applied automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.autoformat?view=word-pia"/>
  public Core.TriState AutoFormat { get; set; }
}
