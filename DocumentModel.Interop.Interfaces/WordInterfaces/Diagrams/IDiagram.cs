namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram?view=word-pia"/>
public interface IDiagram : IInteropObject
{
  /// <summary>
  /// Gets the collection of nodes in the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.nodes?view=word-pia"/>
  public IDiagramNodes Nodes { get; }

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


  #region methods

/// <summary>
  /// Converts the diagram to the specified diagram type.
  /// </summary>
  /// <param name="type">The target diagram type.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.convert?view=word-pia"/>
  public void Convert(Core.DiagramType type);

  #endregion methods
}
