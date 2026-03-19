namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Presentation Of.
/// </summary>
[OpenXmlType(typeof(DXDD.PresentationOf))]
/// <summary>
/// Represents the Presentation Of.
/// </summary>
public class PresentationOf: ModelElement<DXDD.PresentationOf>
{
  /// <summary>
  ///   Axis
  /// </summary>
  public ListOf<AxisType>? Axis { get; set; }
  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ListOf<ElementType>? PointType { get; set; }
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
