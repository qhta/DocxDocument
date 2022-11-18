namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonBehavior Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IAttributeNameList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITargetElement))]
public interface ICommonBehavior // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Additive
  /// </summary>
  public BehaviorAdditive? Additive { get ; set; }
  
  /// <summary>
  /// Accumulate
  /// </summary>
  public BehaviorAccumulate? Accumulate { get ; set; }
  
  /// <summary>
  /// Transform Type
  /// </summary>
  public BehaviorTransform? TransformType { get ; set; }
  
  /// <summary>
  /// From
  /// </summary>
  public string? From { get ; set; }
  
  /// <summary>
  /// To
  /// </summary>
  public string? To { get ; set; }
  
  /// <summary>
  /// By
  /// </summary>
  public string? By { get ; set; }
  
  /// <summary>
  /// Runtime Context
  /// </summary>
  public string? RuntimeContext { get ; set; }
  
  /// <summary>
  /// Override
  /// </summary>
  public BehaviorOverride? Override { get ; set; }
  
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
