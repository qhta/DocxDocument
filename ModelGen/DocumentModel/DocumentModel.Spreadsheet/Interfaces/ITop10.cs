namespace DocumentModel.Spreadsheet;

/// <summary>
/// Top 10.
/// </summary>
public interface ITop10 // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Top
  /// </summary>
  public Boolean? Top { get ; set; }
  
  /// <summary>
  /// Filter by Percent
  /// </summary>
  public Boolean? Percent { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public Double? Val { get ; set; }
  
  /// <summary>
  /// Filter Value
  /// </summary>
  public Double? FilterValue { get ; set; }
  
}
