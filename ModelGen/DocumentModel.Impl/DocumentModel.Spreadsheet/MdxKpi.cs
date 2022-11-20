namespace DocumentModel.Spreadsheet;

/// <summary>
/// KPI MDX Metadata.
/// </summary>
public class MdxKpi: IMdxKpi
{
  /// <summary>
  /// Member Unique Name Index
  /// </summary>
  public uint? NameIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// KPI Index
  /// </summary>
  public uint? KpiIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// KPI Property
  /// </summary>
  public MdxKPIPropertyValues? KpiProperty
  {
    get;
    set;
  }
  
}
