namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Else.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IAlgorithm))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IChoose))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IConstraints))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IForEach))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ILayoutNode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPresentationOf))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IRuleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IShape))]
public class DiagramChooseElse: IDiagramChooseElse
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
