namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an alpha modulate fixed effect.
/// </summary>
public partial class AlphaModulationFixed
{
  
  /// <summary>
  ///   Specifies the percentage amount to scale the alpha.
  /// </summary>
  [SchemaAttr("amt")]
  public Int32? Amount { get; set; }
  
}
