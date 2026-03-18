namespace DocumentModel.Interop;

public partial interface Diagram
{
  /// <summary>
  /// Converts the diagram to the specified diagram type.
  /// </summary>
  /// <param name="Type">The target diagram type.</param>
  public void Convert(Core.MsoDiagramType Type);
}
