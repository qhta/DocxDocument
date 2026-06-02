namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram?view=word-pia"/>
public partial interface IDiagram
{
  /// <summary>
  /// Converts the diagram to the specified diagram type.
  /// </summary>
  /// <param name="Type">The target diagram type.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagram.convert?view=word-pia"/>
  public void Convert(Core.DiagramType Type);
}
