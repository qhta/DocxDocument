namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ColorType Class.
/// </summary>
public class ColorType: ModelElement
{
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}