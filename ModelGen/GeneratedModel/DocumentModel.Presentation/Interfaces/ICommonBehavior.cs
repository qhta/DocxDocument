namespace DocumentModel.Presentation;

public interface ICommonBehavior // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BehaviorAdditive? Additive { get ; set; }

  public BehaviorAccumulate? Accumulate { get ; set; }

  public BehaviorTransform? TransformType { get ; set; }

  public string? From { get ; set; }

  public string? To { get ; set; }

  public string? By { get ; set; }

  public string? RuntimeContext { get ; set; }

  public BehaviorOverride? Override { get ; set; }

  public ICommonTimeNode? CommonTimeNode { get ; set; }

  public ITargetElement? TargetElement { get ; set; }

  public IAttributeNameList? AttributeNameList { get ; set; }

}
