namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonBehavior Class.
/// </summary>
public interface ICommonBehavior // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Additive
  /// </summary>
  public BehaviorAdditiveKind? Additive { get ; set; }
  
  /// <summary>
  /// Accumulate
  /// </summary>
  public BehaviorAccumulateKind? Accumulate { get ; set; }
  
  /// <summary>
  /// Transform Type
  /// </summary>
  public BehaviorTransformKind? TransformType { get ; set; }
  
  /// <summary>
  /// From
  /// </summary>
  public String? From { get ; set; }
  
  /// <summary>
  /// To
  /// </summary>
  public String? To { get ; set; }
  
  /// <summary>
  /// By
  /// </summary>
  public String? By { get ; set; }
  
  /// <summary>
  /// Runtime Context
  /// </summary>
  public String? RuntimeContext { get ; set; }
  
  /// <summary>
  /// Override
  /// </summary>
  public BehaviorOverrideKind? Override { get ; set; }
  
  /// <summary>
  /// CommonTimeNode.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// Target Element.
  /// </summary>
  public ITargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Attribute Name List.
  /// </summary>
  public IAttributeNameList? AttributeNameList { get ; set; }
  
}
