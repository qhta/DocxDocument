namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
