namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Line Color List.
/// </summary>
public class TextLineColorList: ModelElement
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public HslColor? HslColor { get; set; }

  public SystemColor? SystemColor { get; set; }

  public SchemeColor? SchemeColor { get; set; }

  public PresetColor? PresetColor { get; set; }
}