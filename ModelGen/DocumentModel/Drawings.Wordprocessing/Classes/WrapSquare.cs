namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Square Wrapping.
/// </summary>
public partial class WrapSquare
{
  
  /// <summary>
  ///   Text Wrapping Location
  /// </summary>
  [SchemaAttr("wrapText")]
  public DocumentModel.Drawings.Wordprocessing.WrapTextValues? WrapText { get; set; }
  
  
  /// <summary>
  ///   Distance From Text (Top)
  /// </summary>
  [SchemaAttr("distT")]
  public UInt32? DistanceFromTop { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  [SchemaAttr("distB")]
  public UInt32? DistanceFromBottom { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  [SchemaAttr("distL")]
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  [SchemaAttr("distR")]
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   Object Extents Including Effects.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.EffectExtent? EffectExtent { get; set; }
  
}
