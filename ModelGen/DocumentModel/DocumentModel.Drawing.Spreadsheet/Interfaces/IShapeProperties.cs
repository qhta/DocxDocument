namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Shape Properties.
/// </summary>
public interface IShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
}
