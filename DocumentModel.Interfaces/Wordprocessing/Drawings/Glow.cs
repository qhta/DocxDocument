using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Glow Class.
/// </summary>
public interface Glow: ITypedModelElement, DrawingProperty
{
  /// <summary>
  ///   rad
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