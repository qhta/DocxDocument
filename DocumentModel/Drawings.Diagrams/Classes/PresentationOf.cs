namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Presentation Of.
/// </summary>
public class PresentationOf: ModelElement
{
  /// <summary>
  ///   Axis
  /// </summary>
  public ListOf<AxisKind>? Axis { get; set; }

  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ListOf<ElementKind>? PointType { get; set; }

  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  public ListOf<Boolean>? HideLastTrans { get; set; }

  /// <summary>
  ///   Start
  /// </summary>
  public ListOf<Int32>? Start { get; set; }

  /// <summary>
  ///   Count
  /// </summary>
  public ListOf<UInt32>? Count { get; set; }

  /// <summary>
  ///   Step
  /// </summary>
  public ListOf<Int32>? Step { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}