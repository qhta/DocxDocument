namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Kpis Class.
/// </summary>
public interface Kpis // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// KPI Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Kpi>? Kpis { get ; set; }
  
}
