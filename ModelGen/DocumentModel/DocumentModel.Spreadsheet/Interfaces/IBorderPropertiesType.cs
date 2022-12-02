namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the BorderPropertiesType Class.
/// </summary>
public interface IBorderPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Line Style
  /// </summary>
  public BorderStyleKind? Style { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public IColorType? Color { get ; set; }
  
}
