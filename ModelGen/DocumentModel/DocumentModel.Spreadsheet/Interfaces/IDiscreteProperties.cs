namespace DocumentModel.Spreadsheet;

/// <summary>
/// Discrete Grouping Properties.
/// </summary>
public interface IDiscreteProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Mapping Index Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? FieldItems { get ; set; }
  
}
