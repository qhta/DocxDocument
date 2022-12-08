namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public class GlowImpl: ModelElementImpl, Glow
{
  public DocumentFormat.OpenXml.Office2010.Word.Glow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Glow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? GlowRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
