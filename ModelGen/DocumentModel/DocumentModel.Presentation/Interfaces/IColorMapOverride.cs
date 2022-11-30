namespace DocumentModel.Presentation;

/// <summary>
/// Color Scheme Map Override.
/// </summary>
public interface IColorMapOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Master Color Mapping.
  /// </summary>
  public System.Boolean? MasterColorMapping { get ; set; }
  
  /// <summary>
  /// Override Color Mapping.
  /// </summary>
  public DocumentModel.Drawing.IOverrideColorMapping? OverrideColorMapping { get ; set; }
  
}
