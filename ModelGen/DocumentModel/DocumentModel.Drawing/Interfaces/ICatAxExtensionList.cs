namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public interface ICatAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICatAxExtension>? CatAxExtensions { get ; set; }
  
}
