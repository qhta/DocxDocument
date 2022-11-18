namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the FirstMarkerColor Class.
/// </summary>
public interface IFirstMarkerColor // : DocumentFormat.OpenXml.Office2010.Excel.ColorType
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
