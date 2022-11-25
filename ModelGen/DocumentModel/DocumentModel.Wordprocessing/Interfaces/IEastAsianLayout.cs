namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public interface IEastAsianLayout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public System.Int32? Id { get ; set; }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public System.Boolean? Combine { get ; set; }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public DocumentModel.Wordprocessing.CombineBracketKind? CombineBrackets { get ; set; }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public System.Boolean? Vertical { get ; set; }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public System.Boolean? VerticalCompress { get ; set; }
  
}
