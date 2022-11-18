namespace DocumentModel.Presentation;

/// <summary>
/// Color Scheme Map Override.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOverrideColorMapping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IMasterColorMapping))]
public interface IColorMapOverride // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Master Color Mapping.
  /// </summary>
  public IMasterColorMapping? MasterColorMapping { get ; set; }
  
  /// <summary>
  /// Override Color Mapping.
  /// </summary>
  public IOverrideColorMapping? OverrideColorMapping { get ; set; }
  
}
