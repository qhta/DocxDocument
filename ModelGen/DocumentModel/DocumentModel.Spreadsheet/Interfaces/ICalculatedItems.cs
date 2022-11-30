namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedItems Class.
/// </summary>
public interface ICalculatedItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Calculated Item Formula Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICalculatedItem>? CalculatedItems { get ; set; }
  
}
