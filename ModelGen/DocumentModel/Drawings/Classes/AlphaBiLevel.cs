namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an Alpha Bi-Level Effect.
/// </summary>
public partial class AlphaBiLevel
{
  
  /// <summary>
  ///   Specifies the threshold value for the alpha bi-level effect.
  /// </summary>
  [SchemaAttr("thresh")]
  public Int32? Threshold { get; set; }
  
}
