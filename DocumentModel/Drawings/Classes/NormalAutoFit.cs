namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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