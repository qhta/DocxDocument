namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IAlgorithm))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IChoose))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IConstraints))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IForEach))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ILayoutNode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IVariableList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPresentationOf))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IRuleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IShape))]
public class LayoutNode: ILayoutNode
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public string? StyleLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public ChildOrderValues? ChildOrder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  public string? MoveWith
  {
    get;
    set;
  }
  
}
