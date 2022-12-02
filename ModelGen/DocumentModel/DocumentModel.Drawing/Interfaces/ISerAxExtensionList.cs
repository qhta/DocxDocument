namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public interface ISerAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISerAxExtension>? SerAxExtensions { get ; set; }
  
}
