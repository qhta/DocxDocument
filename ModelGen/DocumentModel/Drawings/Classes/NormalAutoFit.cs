namespace DocumentModel.Drawings;


/// <summary>
///   Normal AutoFit.
/// </summary>
public partial class NormalAutoFit
{
  
  /// <summary>
  ///   Font Scale
  /// </summary>
  [SchemaAttr("fontScale")]
  public Int32? FontScale { get; set; }
  
  
  /// <summary>
  ///   Line Space Reduction
  /// </summary>
  [SchemaAttr("lnSpcReduction")]
  public Int32? LineSpaceReduction { get; set; }
  
}
