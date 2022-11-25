namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
