namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the ContextualTabSet Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ITab))]
public class ContextualTabSet: IContextualTabSet
{
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public bool? Visible
  {
    get;
    set;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public string? GetVisible
  {
    get;
    set;
  }
  
}
