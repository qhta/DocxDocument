namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public class ColorTypeImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.ColorType>, ColorType
{
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
