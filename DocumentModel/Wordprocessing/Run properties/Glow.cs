namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Glow Class.
/// </summary>
public class Glow: ModelElement
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