namespace DocumentModel.Drawings;

/// <summary>
///   Followed Hyperlink.
/// </summary>
public class FollowedHyperlinkColor
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public HslColor? HslColor { get; set; }

  public SystemColor? SystemColor { get; set; }

  public PresetColor? PresetColor { get; set; }
}