namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IExtension>? Extensions { get ; set; }
  
}
