namespace DocumentModel.Spreadsheet;

/// <summary>
/// Top 10.
/// </summary>
public interface ITop10 // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Top
  /// </summary>
  public bool? Top { get ; set; }
  
  /// <summary>
  /// Filter by Percent
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public double? Val { get ; set; }
  
  /// <summary>
  /// Filter Value
  /// </summary>
  public double? FilterValue { get ; set; }
  
}
