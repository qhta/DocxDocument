namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDiagramChooseElse))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDiagramChooseIf))]
public class Choose: IChoose
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
