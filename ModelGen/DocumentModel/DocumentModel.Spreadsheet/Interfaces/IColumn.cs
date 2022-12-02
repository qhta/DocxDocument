namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Width and Formatting.
/// </summary>
public interface IColumn // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Minimum Column
  /// </summary>
  public UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum Column
  /// </summary>
  public UInt32? Max { get ; set; }
  
  /// <summary>
  /// Column Width
  /// </summary>
  public Double? Width { get ; set; }
  
  /// <summary>
  /// Style
  /// </summary>
  public UInt32? Style { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Best Fit Column Width
  /// </summary>
  public Boolean? BestFit { get ; set; }
  
  /// <summary>
  /// Custom Width
  /// </summary>
  public Boolean? CustomWidth { get ; set; }
  
  /// <summary>
  /// Show Phonetic Information
  /// </summary>
  public Boolean? Phonetic { get ; set; }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public Byte? OutlineLevel { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public Boolean? Collapsed { get ; set; }
  
}
