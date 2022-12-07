namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public class ContourColorImpl: DocumentModel.Wordprocessing.ColorTypeImpl, ContourColor
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
