namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public interface TextFontType
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public String? Typeface { get ; set; }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public DocumentModel.HexBinaryValue? Panose { get ; set; }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public SByte? PitchFamily { get ; set; }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public SByte? CharacterSet { get ; set; }
  
}
