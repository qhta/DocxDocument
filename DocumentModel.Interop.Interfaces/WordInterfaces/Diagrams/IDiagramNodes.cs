namespace DocumentModel.Interop.Word;	
/// <summary>
/// A collection of DiagramNode objects that represent all the nodes in a diagram. The DiagramNodes collection contains all the diagram nodes in a specified diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodes?view=word-pia"/>
public interface IDiagramNodes : IInteropObject, IInteropCollection<IDiagramNode>
{	

  #region methods	
/// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodes.selectall?view=word-pia"/>
  public void SelectAll();	
  #endregion methods
}
