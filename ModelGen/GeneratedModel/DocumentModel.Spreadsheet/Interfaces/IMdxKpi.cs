namespace DocumentModel.Spreadsheet;

/// <summary>
/// KPI MDX Metadata.
/// </summary>
public interface IMdxKpi // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Member Unique Name Index
  /// </summary>
  public uint? NameIndex { get ; set; }
  
  /// <summary>
  /// KPI Index
  /// </summary>
  public uint? KpiIndex { get ; set; }
  
  /// <summary>
  /// KPI Property
  /// </summary>
  public MdxKPIProperty? KpiProperty { get ; set; }
  
}
