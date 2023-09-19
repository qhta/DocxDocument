namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an alpha replace effect.
/// </summary>
public partial class AlphaReplace
{
  
  /// <summary>
  ///   Specifies the new opacity value.
  /// </summary>
  [SchemaAttr("a")]
  public Int32? Alpha { get; set; }
  
}
