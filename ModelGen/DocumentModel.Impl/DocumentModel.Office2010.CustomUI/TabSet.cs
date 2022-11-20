namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the TabSet Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ITab))]
public class TabSet: ITabSet
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible
  {
    get;
    set;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible
  {
    get;
    set;
  }
  
}
