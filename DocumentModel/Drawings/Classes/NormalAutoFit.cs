namespace DocumentModel.Drawings;

/// <summary>
///   Normal AutoFit.
/// </summary>
public class NormalAutoFit: ModelElement
{
  /// <summary>
  ///   Font Scale
  /// </summary>
  public Int32? FontScale { get; set; }

  /// <summary>
  ///   Line Space Reduction
  /// </summary>
  public Int32? LineSpaceReduction { get; set; }
}