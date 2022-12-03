namespace DocumentModel.Presentation;

/// <summary>
/// Color Scheme Map Override.
/// </summary>
public interface ColorMapOverride // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Master Color Mapping.
  /// </summary>
  public Boolean? MasterColorMapping { get ; set; }
  
  /// <summary>
  /// Override Color Mapping.
  /// </summary>
  public DocumentModel.Drawings.OverrideColorMapping? OverrideColorMapping { get ; set; }
  
}
