namespace DocumentModel.Presentation;

/// <summary>
/// Color Scheme Map Override.
/// </summary>
public interface IColorMapOverride // : DocumentModel.ITypedOpenXmlCompositeElement
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
