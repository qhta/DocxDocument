namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public class TextFontTypeImpl: ModelElementImpl, TextFontType
{
  public DocumentFormat.OpenXml.Drawing.TextFontType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextFontType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Text Typeface
  /// </summary>
  public String? Typeface
  {
    get;
    set;
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public DocumentModel.HexBinaryValue? Panose
  {
    get;
    set;
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public SByte? PitchFamily
  {
    get;
    set;
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public SByte? CharacterSet
  {
    get;
    set;
  }
  
}
