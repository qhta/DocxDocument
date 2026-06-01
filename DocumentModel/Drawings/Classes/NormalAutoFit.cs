namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Normal AutoFit.
/// </summary>
public class NormalAutoFit: ModelElement
{
  /// <summary>
  ///   IFont Scale
  /// </summary>
  public Int32? FontScale { get; set; }

  /// <summary>
  ///   ILine Space Reduction
  /// </summary>
  public Int32? LineSpaceReduction { get; set; }
}
