namespace DocumentModel.Drawings;

/// <summary>
/// Followed Hyperlink.
/// </summary>
public class FollowedHyperlinkColorImpl: DocumentModel.Drawings.Color2TypeImpl, FollowedHyperlinkColor
{
  public override RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public override HslColor? HslColor
  {
    get;
    set;
  }
  
  public override SystemColor? SystemColor
  {
    get;
    set;
  }
  
  public override PresetColor? PresetColor
  {
    get;
    set;
  }
  
}
