namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public class ExtrusionColorImpl: DocumentModel.Wordprocessing.ColorTypeImpl, ExtrusionColor
{
  public override RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public override SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
