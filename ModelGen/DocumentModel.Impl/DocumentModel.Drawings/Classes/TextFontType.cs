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
  
  public TextFontTypeImpl(): base() {}
  
  public TextFontTypeImpl(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Typeface
  /// </summary>
  public String? Typeface
  {
    get => (System.String?)OpenXmlElement?.Typeface?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Typeface = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public DocumentModel.HexBinaryValue? Panose
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public SByte? PitchFamily
  {
    get => (System.SByte?)OpenXmlElement?.PitchFamily?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PitchFamily = (System.SByte?)value;
    }
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public SByte? CharacterSet
  {
    get => (System.SByte?)OpenXmlElement?.CharacterSet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CharacterSet = (System.SByte?)value;
    }
  }
  
}
