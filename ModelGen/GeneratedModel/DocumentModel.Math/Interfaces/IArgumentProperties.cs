namespace DocumentModel.Math;

/// <summary>
/// Argument Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IArgumentSize))]
public interface IArgumentProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  public IArgumentSize? ArgumentSize { get ; set; }
  
}
