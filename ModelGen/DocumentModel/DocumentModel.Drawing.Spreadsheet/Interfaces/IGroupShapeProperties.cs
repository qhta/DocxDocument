namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Group Shape Properties.
/// </summary>
public interface IGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public ITransformGroup? TransformGroup { get ; set; }
  
}
