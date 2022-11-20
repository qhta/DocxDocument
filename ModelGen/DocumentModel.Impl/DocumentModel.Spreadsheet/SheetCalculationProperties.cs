namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SheetCalculationProperties Class.
/// </summary>
public class SheetCalculationProperties: ISheetCalculationProperties
{
  /// <summary>
  /// Full Calculation On Load
  /// </summary>
  public bool? FullCalculationOnLoad
  {
    get;
    set;
  }
  
}
