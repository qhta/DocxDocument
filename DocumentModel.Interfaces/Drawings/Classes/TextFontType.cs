namespace DocumentModel.Drawings;

/// <summary>
///   Defines the TextFontType Class.
/// </summary>
public class TextFontType: ModelElement
{
  /// <summary>
  ///   Text Typeface
  /// </summary>
  public string? Typeface { get; set; }
  /// <summary>
  ///   Panose Setting
  /// </summary>
   public IHexBinary? Panose { get; set; }
  /// <summary>
  ///   Similar Font Family
  /// </summary>
  public SByte? PitchFamily { get; set; }
  /// <summary>
  ///   Similar Character Set
  /// </summary>
  public SByte? CharacterSet { get; set; }
}