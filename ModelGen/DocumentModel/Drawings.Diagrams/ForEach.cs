namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   For Each.
/// </summary>
public partial class ForEach
{
  
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Reference
  /// </summary>
  public String? Reference { get; set; }
  
  
  /// <summary>
  ///   Axis
  /// </summary>
  public DM.ListOf<AxisKind>? Axis { get; set; }
  
  
  /// <summary>
  ///   Data Point Type
  /// </summary>
  public DM.ListOf<ElementKind>? PointType { get; set; }
  
  
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  public DM.ListOf<Boolean>? HideLastTrans { get; set; }
  
  
  /// <summary>
  ///   Start
  /// </summary>
  public DM.ListOf<Int32>? Start { get; set; }
  
  
  /// <summary>
  ///   Count
  /// </summary>
  public DM.ListOf<UInt32>? Count { get; set; }
  
  
  /// <summary>
  ///   Step
  /// </summary>
  public DM.ListOf<Int32>? Step { get; set; }
  
}
