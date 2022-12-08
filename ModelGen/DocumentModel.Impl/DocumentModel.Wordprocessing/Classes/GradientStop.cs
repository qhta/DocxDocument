namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public class GradientStopImpl: ModelElementImpl, GradientStop
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StopPosition
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
