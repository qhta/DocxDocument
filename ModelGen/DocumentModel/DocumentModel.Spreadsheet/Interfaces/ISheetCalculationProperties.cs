namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SheetCalculationProperties Class.
/// </summary>
public interface ISheetCalculationProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Full Calculation On Load
  /// </summary>
  public System.Boolean? FullCalculationOnLoad { get ; set; }
  
}
