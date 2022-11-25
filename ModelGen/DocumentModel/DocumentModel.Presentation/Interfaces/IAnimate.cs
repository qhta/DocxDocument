namespace DocumentModel.Presentation;

/// <summary>
/// Animate.
/// </summary>
public interface IAnimate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// by
  /// </summary>
  public System.String? By { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public System.String? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public System.String? To { get ; set; }
  
  /// <summary>
  /// calcmode
  /// </summary>
  public DocumentModel.Presentation.AnimateBehaviorCalculateMode? CalculationMode { get ; set; }
  
  /// <summary>
  /// valueType
  /// </summary>
  public DocumentModel.Presentation.AnimateBehaviorKind? ValueType { get ; set; }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? BounceEnd { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// TimeAnimateValueList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TimeAnimateValueList { get ; set; }
  
}
