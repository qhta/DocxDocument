namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Text ILine IBreak.
/// </summary>
public class IBreak: ModelElement
{
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}
