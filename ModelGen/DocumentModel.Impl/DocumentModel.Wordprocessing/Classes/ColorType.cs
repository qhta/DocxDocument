namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public class ColorTypeImpl: ModelElementImpl, ColorType
{
  public DocumentFormat.OpenXml.Office2010.Word.ColorType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.ColorType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public virtual RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public virtual SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
