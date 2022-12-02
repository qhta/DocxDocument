namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ControlProperties Class.
/// </summary>
public interface IControlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// locked
  /// </summary>
  public Boolean? Locked { get ; set; }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public Boolean? DefaultSize { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public Boolean? Print { get ; set; }
  
  /// <summary>
  /// disabled
  /// </summary>
  public Boolean? Disabled { get ; set; }
  
  /// <summary>
  /// recalcAlways
  /// </summary>
  public Boolean? RecalcAlways { get ; set; }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public Boolean? UiObject { get ; set; }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public Boolean? AutoFill { get ; set; }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public Boolean? AutoLine { get ; set; }
  
  /// <summary>
  /// autoPict
  /// </summary>
  public Boolean? AutoPict { get ; set; }
  
  /// <summary>
  /// macro
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// altText
  /// </summary>
  public String? AltText { get ; set; }
  
  /// <summary>
  /// linkedCell
  /// </summary>
  public String? LinkedCell { get ; set; }
  
  /// <summary>
  /// listFillRange
  /// </summary>
  public String? ListFillRange { get ; set; }
  
  /// <summary>
  /// cf
  /// </summary>
  public String? Cf { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public IObjectAnchor? ObjectAnchor { get ; set; }
  
}
