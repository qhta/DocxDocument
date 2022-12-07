namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public class SolidColorFillPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>, SolidColorFillProperties
{
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
