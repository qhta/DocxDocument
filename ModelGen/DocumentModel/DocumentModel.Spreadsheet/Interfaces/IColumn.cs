namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Width and Formatting.
/// </summary>
public interface IColumn // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Minimum Column
  /// </summary>
  public System.UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum Column
  /// </summary>
  public System.UInt32? Max { get ; set; }
  
  /// <summary>
  /// Column Width
  /// </summary>
  public System.Double? Width { get ; set; }
  
  /// <summary>
  /// Style
  /// </summary>
  public System.UInt32? Style { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Best Fit Column Width
  /// </summary>
  public System.Boolean? BestFit { get ; set; }
  
  /// <summary>
  /// Custom Width
  /// </summary>
  public System.Boolean? CustomWidth { get ; set; }
  
  /// <summary>
  /// Show Phonetic Information
  /// </summary>
  public System.Boolean? Phonetic { get ; set; }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public System.Byte? OutlineLevel { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public System.Boolean? Collapsed { get ; set; }
  
}
