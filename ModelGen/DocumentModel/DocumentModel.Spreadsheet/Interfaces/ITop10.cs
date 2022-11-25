namespace DocumentModel.Spreadsheet;

/// <summary>
/// Top 10.
/// </summary>
public interface ITop10 // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Top
  /// </summary>
  public System.Boolean? Top { get ; set; }
  
  /// <summary>
  /// Filter by Percent
  /// </summary>
  public System.Boolean? Percent { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
  /// <summary>
  /// Filter Value
  /// </summary>
  public System.Double? FilterValue { get ; set; }
  
}
