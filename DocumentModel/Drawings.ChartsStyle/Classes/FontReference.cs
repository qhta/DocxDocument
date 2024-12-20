namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontReference Class.
/// </summary>
public class FontReference: ModelElement
{
  /// <summary>
  ///   idx, this property is only available in Office 2013 and later.
  /// </summary>
  public FontCollectionIndexKind? Index { get; set; }

  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }

  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public HslColor? HslColor { get; set; }

  public SystemColor? SystemColor { get; set; }

  public SchemeColor? SchemeColor { get; set; }

  public PresetColor? PresetColor { get; set; }

  public StyleColor? StyleColor { get; set; }
}