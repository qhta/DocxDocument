namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// For Each.
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
public class ForEach: IForEach
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
  /// Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisValues>? Axis
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementValues>? PointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<bool>? HideLastTrans
  {
    get;
    set;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<int>? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<uint>? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<int>? Step
  {
    get;
    set;
  }
  
}
