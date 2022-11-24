namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public interface ITextFontType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public String? Typeface { get ; set; }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public IHexBinaryValue? Panose { get ; set; }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public SByte? PitchFamily { get ; set; }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public SByte? CharacterSet { get ; set; }
  
}
