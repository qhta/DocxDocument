namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Kpis Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IKpi))]
public class Kpis: IKpis
{
  /// <summary>
  /// KPI Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
