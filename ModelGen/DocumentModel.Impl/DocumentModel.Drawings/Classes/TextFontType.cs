namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public partial class TextFontTypeImpl: ModelElementImpl, TextFontType
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
  public DocumentModel.HexBinary? Panose
  {
    get
    {
      if (OpenXmlElement?.Panose?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Panose.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Panose = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Panose = null;
      }
    }
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
