namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtensionList Class.
/// </summary>
public interface ISlideMasterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISlideMasterExtension>? SlideMasterExtensions { get ; set; }
  
}
