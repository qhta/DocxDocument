namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonBehavior Class.
/// </summary>
public interface ICommonBehavior // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Additive
  /// </summary>
  public DocumentModel.Presentation.BehaviorAdditiveKind? Additive { get ; set; }
  
  /// <summary>
  /// Accumulate
  /// </summary>
  public DocumentModel.Presentation.BehaviorAccumulateKind? Accumulate { get ; set; }
  
  /// <summary>
  /// Transform Type
  /// </summary>
  public DocumentModel.Presentation.BehaviorTransformKind? TransformType { get ; set; }
  
  /// <summary>
  /// From
  /// </summary>
  public System.String? From { get ; set; }
  
  /// <summary>
  /// To
  /// </summary>
  public System.String? To { get ; set; }
  
  /// <summary>
  /// By
  /// </summary>
  public System.String? By { get ; set; }
  
  /// <summary>
  /// Runtime Context
  /// </summary>
  public System.String? RuntimeContext { get ; set; }
  
  /// <summary>
  /// Override
  /// </summary>
  public DocumentModel.Presentation.BehaviorOverrideKind? Override { get ; set; }
  
  /// <summary>
  /// CommonTimeNode.
  /// </summary>
  public DocumentModel.Presentation.ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// Target Element.
  /// </summary>
  public DocumentModel.Presentation.ITargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Attribute Name List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? AttributeNameList { get ; set; }
  
}
