namespace DocumentModel.Drawings;

/// <summary>
///   Defines the TextFontType interface.
/// </summary>
public interface TextFontType: IModelElement
{
  /// <summary>
  ///   Text Typeface
  /// </summary>
  public string? Typeface { get; set; }
  /// <summary>
  ///   Panose Setting
  /// </summary>
   public HexBinary? Panose { get; set; }
  /// <summary>
  ///   Similar Font Family
  /// </summary>
  public SByte? PitchFamily { get; set; }
  /// <summary>
  ///   Similar Character Set
  /// </summary>
  public SByte? CharacterSet { get; set; }
}