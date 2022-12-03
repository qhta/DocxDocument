namespace DocumentModel.Drawings;

/// <summary>
/// Presentation Of.
/// </summary>
public interface PresentationOf // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
