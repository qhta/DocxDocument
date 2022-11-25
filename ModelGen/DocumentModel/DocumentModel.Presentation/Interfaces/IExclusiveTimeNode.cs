namespace DocumentModel.Presentation;

/// <summary>
/// Exclusive.
/// </summary>
public interface IExclusiveTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonTimeNode? CommonTimeNode { get ; set; }
  
}
