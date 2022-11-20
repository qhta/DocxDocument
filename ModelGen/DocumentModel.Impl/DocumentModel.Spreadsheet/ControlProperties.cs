namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ControlProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IObjectAnchor))]
public class ControlProperties: IControlProperties
{
  /// <summary>
  /// locked
  /// </summary>
  public bool? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public bool? DefaultSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// print
  /// </summary>
  public bool? Print
  {
    get;
    set;
  }
  
  /// <summary>
  /// disabled
  /// </summary>
  public bool? Disabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// recalcAlways
  /// </summary>
  public bool? RecalcAlways
  {
    get;
    set;
  }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public bool? UiObject
  {
    get;
    set;
  }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public bool? AutoFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public bool? AutoLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// autoPict
  /// </summary>
  public bool? AutoPict
  {
    get;
    set;
  }
  
  /// <summary>
  /// macro
  /// </summary>
  public string? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// altText
  /// </summary>
  public string? AltText
  {
    get;
    set;
  }
  
  /// <summary>
  /// linkedCell
  /// </summary>
  public string? LinkedCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// listFillRange
  /// </summary>
  public string? ListFillRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// cf
  /// </summary>
  public string? Cf
  {
    get;
    set;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public IObjectAnchor? ObjectAnchor
  {
    get;
    set;
  }
  
}
