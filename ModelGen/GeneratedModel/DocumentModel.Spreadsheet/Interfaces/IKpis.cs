namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Kpis Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IKpi))]
public interface IKpis // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// KPI Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
