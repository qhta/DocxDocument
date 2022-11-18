namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public interface IEastAsianLayout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public int? Id { get ; set; }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public bool? Combine { get ; set; }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracket? CombineBrackets { get ; set; }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public bool? Vertical { get ; set; }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public bool? VerticalCompress { get ; set; }
  
}
