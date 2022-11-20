namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the Tab Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IGroup))]
public class Tab: ITab
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public string? IdQ
  {
    get;
    set;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public string? Tag
  {
    get;
    set;
  }
  
  /// <summary>
  /// label
  /// </summary>
  public string? Label
  {
    get;
    set;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public string? GetLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public string? InsertAfterMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public string? InsertAfterQ
  {
    get;
    set;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ
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
  
  /// <summary>
  /// keytip
  /// </summary>
  public string? Keytip
  {
    get;
    set;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public string? GetKeytip
  {
    get;
    set;
  }
  
}
