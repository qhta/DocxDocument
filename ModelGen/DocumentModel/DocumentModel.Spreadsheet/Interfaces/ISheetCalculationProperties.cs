namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SheetCalculationProperties Class.
/// </summary>
public interface ISheetCalculationProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Full Calculation On Load
  /// </summary>
  public bool? FullCalculationOnLoad { get ; set; }
  
}
