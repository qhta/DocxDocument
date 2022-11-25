namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public interface IStringDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.StringDimensionType? Type { get ; set; }
  
}
