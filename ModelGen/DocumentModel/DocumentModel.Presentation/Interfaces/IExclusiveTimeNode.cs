namespace DocumentModel.Presentation;

/// <summary>
/// Exclusive.
/// </summary>
public interface IExclusiveTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
}
