namespace DocumentModel.Drawing;

/// <summary>
/// Complex Script Font.
/// </summary>
public interface IComplexScriptFont // : DocumentFormat.OpenXml.Drawing.TextFontType
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public string? Typeface { get ; set; }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public IHexBinaryValue? Panose { get ; set; }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public sbyte? PitchFamily { get ; set; }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public sbyte? CharacterSet { get ; set; }
  
}
