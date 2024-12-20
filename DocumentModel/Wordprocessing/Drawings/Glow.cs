using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Glow Class.
/// </summary>
public class Glow: TypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   rad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? GlowRadius { get; set; }

  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}