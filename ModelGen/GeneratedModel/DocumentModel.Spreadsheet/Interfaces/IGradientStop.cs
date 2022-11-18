namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Stop.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public interface IGradientStop // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Stop Position
  /// </summary>
  public double? Position { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }
  
}
