namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SheetCalculationProperties Class.
/// </summary>
public interface SheetCalculationProperties // : System.Boolean
{
  /// <summary>
  /// Full Calculation On Load
  /// </summary>
  public Boolean? FullCalculationOnLoad { get ; set; }
  
}
