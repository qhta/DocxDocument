namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Inner Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public interface IVerticalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
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
