namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public class GradientStopImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.GradientStop>, GradientStop
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
