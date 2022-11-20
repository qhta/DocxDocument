namespace DocumentModel.Presentation;

/// <summary>
/// Exclusive.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
public interface IExclusiveTimeNode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
}
