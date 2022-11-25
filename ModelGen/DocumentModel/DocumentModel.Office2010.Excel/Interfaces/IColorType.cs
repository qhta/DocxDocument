namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface IColorType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Automatic
  /// </summary>
  public System.Boolean? Auto { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public System.UInt32? Indexed { get ; set; }
  
  /// <summary>
  /// Alpha Red Green Blue Color Value
  /// </summary>
  public DocumentModel.IHexBinaryValue? Rgb { get ; set; }
  
  /// <summary>
  /// Theme Color
  /// </summary>
  public System.UInt32? Theme { get ; set; }
  
  /// <summary>
  /// Tint
  /// </summary>
  public System.Double? Tint { get ; set; }
  
}
