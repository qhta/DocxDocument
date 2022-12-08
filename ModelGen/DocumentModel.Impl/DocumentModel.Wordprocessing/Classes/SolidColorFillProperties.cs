namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public class SolidColorFillPropertiesImpl: ModelElementImpl, SolidColorFillProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
