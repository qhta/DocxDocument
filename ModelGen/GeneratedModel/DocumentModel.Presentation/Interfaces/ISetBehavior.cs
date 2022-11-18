namespace DocumentModel.Presentation;

/// <summary>
/// Set Time Node Behavior.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IToVariantValue))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public interface ISetBehavior // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common Behavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public IToVariantValue? ToVariantValue { get ; set; }
  
}
