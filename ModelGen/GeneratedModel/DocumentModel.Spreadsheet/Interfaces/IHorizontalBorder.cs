namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Inner Borders.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public interface IHorizontalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
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
