namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Tab Color.
/// </summary>
public interface ITabColor // : DocumentFormat.OpenXml.Spreadsheet.ColorType
{
  /// <summary>
  /// Automatic
  /// </summary>
  public bool? Auto { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public uint? Indexed { get ; set; }
  
  /// <summary>
  /// Alpha Red Green Blue Color Value
  /// </summary>
  public IHexBinaryValue? Rgb { get ; set; }
  
  /// <summary>
  /// Theme Color
  /// </summary>
  public uint? Theme { get ; set; }
  
  /// <summary>
  /// Tint
  /// </summary>
  public double? Tint { get ; set; }
  
}
