namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public class GlowImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Glow>, Glow
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
