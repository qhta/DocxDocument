namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Kpis Class.
/// </summary>
public interface IKpis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// KPI Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IKpi>? Kpis { get ; set; }
  
}
