namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Width and Formatting.
/// </summary>
public interface IColumn // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Minimum Column
  /// </summary>
  public uint? Min { get ; set; }
  
  /// <summary>
  /// Maximum Column
  /// </summary>
  public uint? Max { get ; set; }
  
  /// <summary>
  /// Column Width
  /// </summary>
  public double? Width { get ; set; }
  
  /// <summary>
  /// Style
  /// </summary>
  public uint? Style { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// Best Fit Column Width
  /// </summary>
  public bool? BestFit { get ; set; }
  
  /// <summary>
  /// Custom Width
  /// </summary>
  public bool? CustomWidth { get ; set; }
  
  /// <summary>
  /// Show Phonetic Information
  /// </summary>
  public bool? Phonetic { get ; set; }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public byte? OutlineLevel { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public bool? Collapsed { get ; set; }
  
}
