namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Stop.
/// </summary>
public interface IGradientStop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Stop Position
  /// </summary>
  public System.Double? Position { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? Color { get ; set; }
  
}
