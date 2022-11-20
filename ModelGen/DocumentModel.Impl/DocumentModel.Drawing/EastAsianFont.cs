namespace DocumentModel.Drawing;

/// <summary>
/// East Asian Font.
/// </summary>
public class EastAsianFont: IEastAsianFont
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public string? Typeface
  {
    get;
    set;
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public IHexBinaryValue? Panose
  {
    get;
    set;
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public sbyte? PitchFamily
  {
    get;
    set;
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public sbyte? CharacterSet
  {
    get;
    set;
  }
  
}
