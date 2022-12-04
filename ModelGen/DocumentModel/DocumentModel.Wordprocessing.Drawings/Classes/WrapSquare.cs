namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Square Wrapping.
/// </summary>
public class WrapSquare
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}
