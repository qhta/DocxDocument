namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListModify Class.
/// </summary>
public interface IExtensionListModify // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public Boolean? Modify { get ; set; }
  
  public Collection<IExtension>? Extensions { get ; set; }
  
}
