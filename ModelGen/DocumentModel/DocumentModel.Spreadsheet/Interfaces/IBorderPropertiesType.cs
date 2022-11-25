namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the BorderPropertiesType Class.
/// </summary>
public interface IBorderPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Line Style
  /// </summary>
  public DocumentModel.Spreadsheet.BorderStyleKind? Style { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? Color { get ; set; }
  
}
