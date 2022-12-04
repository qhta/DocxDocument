namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public class ExtrusionColor: DocumentModel.Wordprocessing.ColorType
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
