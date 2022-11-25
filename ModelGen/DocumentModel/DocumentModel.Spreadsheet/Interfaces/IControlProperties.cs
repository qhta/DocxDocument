namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ControlProperties Class.
/// </summary>
public interface IControlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// locked
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public System.Boolean? DefaultSize { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public System.Boolean? Print { get ; set; }
  
  /// <summary>
  /// disabled
  /// </summary>
  public System.Boolean? Disabled { get ; set; }
  
  /// <summary>
  /// recalcAlways
  /// </summary>
  public System.Boolean? RecalcAlways { get ; set; }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public System.Boolean? UiObject { get ; set; }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public System.Boolean? AutoFill { get ; set; }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public System.Boolean? AutoLine { get ; set; }
  
  /// <summary>
  /// autoPict
  /// </summary>
  public System.Boolean? AutoPict { get ; set; }
  
  /// <summary>
  /// macro
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// altText
  /// </summary>
  public System.String? AltText { get ; set; }
  
  /// <summary>
  /// linkedCell
  /// </summary>
  public System.String? LinkedCell { get ; set; }
  
  /// <summary>
  /// listFillRange
  /// </summary>
  public System.String? ListFillRange { get ; set; }
  
  /// <summary>
  /// cf
  /// </summary>
  public System.String? Cf { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public DocumentModel.Spreadsheet.IObjectAnchor? ObjectAnchor { get ; set; }
  
}
