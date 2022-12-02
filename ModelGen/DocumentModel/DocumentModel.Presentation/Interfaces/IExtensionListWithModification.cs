namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListWithModification Class.
/// </summary>
public interface IExtensionListWithModification // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public Boolean? Modify { get ; set; }
  
  public Collection<IExtension>? Extensions { get ; set; }
  
}
