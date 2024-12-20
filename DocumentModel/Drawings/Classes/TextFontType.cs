namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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