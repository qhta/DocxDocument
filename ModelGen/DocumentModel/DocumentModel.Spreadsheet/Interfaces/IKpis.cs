namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Kpis Class.
/// </summary>
public interface IKpis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// KPI Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IKpi>? Kpis { get ; set; }
  
}
