namespace DocumentModel.Presentation;

/// <summary>
/// Color Scheme Map Override.
/// </summary>
public interface IColorMapOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Master Color Mapping.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? MasterColorMapping { get ; set; }
  
  /// <summary>
  /// Override Color Mapping.
  /// </summary>
  public DocumentModel.Drawing.IColorMappingType? OverrideColorMapping { get ; set; }
  
}
