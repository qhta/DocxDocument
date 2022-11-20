namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
public class PresentationOf: IPresentationOf
{
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
