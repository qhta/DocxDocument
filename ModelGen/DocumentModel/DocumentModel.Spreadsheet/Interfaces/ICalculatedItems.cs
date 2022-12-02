namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedItems Class.
/// </summary>
public interface ICalculatedItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Calculated Item Formula Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ICalculatedItem>? CalculatedItems { get ; set; }
  
}
