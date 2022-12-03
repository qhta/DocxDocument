namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface ColorType // : System.Boolean
{
  /// <summary>
  /// Automatic
  /// </summary>
  public Boolean? Auto { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Indexed { get ; set; }
  
  /// <summary>
  /// Alpha Red Green Blue Color Value
  /// </summary>
  public DocumentModel.HexBinaryValue? Rgb { get ; set; }
  
  /// <summary>
  /// Theme Color
  /// </summary>
  public UInt32? Theme { get ; set; }
  
  /// <summary>
  /// Tint
  /// </summary>
  public Double? Tint { get ; set; }
  
}
