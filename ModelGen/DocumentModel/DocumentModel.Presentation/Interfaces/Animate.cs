namespace DocumentModel.Presentation;

/// <summary>
/// Animate.
/// </summary>
public interface Animate // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// by
  /// </summary>
  public String? By { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public String? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public String? To { get ; set; }
  
  /// <summary>
  /// calcmode
  /// </summary>
  public AnimateBehaviorCalculateMode? CalculationMode { get ; set; }
  
  /// <summary>
  /// valueType
  /// </summary>
  public AnimateBehaviorKind? ValueType { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public CommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// TimeAnimateValueList.
  /// </summary>
  public TimeAnimateValueList? TimeAnimateValueList { get ; set; }
  
}
