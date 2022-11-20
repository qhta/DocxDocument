namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortCondition Class.
/// </summary>
public interface ISortCondition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Descending
  /// </summary>
  public bool? Descending { get ; set; }
  
  /// <summary>
  /// Sort By
  /// </summary>
  public SortByValues? SortBy { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// Custom List
  /// </summary>
  public string? CustomList { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// Icon Set
  /// </summary>
  public IconSetValues? IconSet { get ; set; }
  
  /// <summary>
  /// Icon Id
  /// </summary>
  public uint? IconId { get ; set; }
  
}
