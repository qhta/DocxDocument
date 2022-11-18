namespace DocumentModel.Spreadsheet;

/// <summary>
/// Diagonal.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public interface IDiagonalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
{
  /// <summary>
  /// Line Style
  /// </summary>
  public BorderStyle? Style { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }
  
}
