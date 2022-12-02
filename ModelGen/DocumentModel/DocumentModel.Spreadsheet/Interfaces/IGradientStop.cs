namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Stop.
/// </summary>
public interface IGradientStop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Stop Position
  /// </summary>
  public Double? Position { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public IColorType? Color { get ; set; }
  
}
