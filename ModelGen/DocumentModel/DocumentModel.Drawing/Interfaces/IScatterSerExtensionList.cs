namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public interface IScatterSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IScatterSerExtension>? ScatterSerExtensions { get ; set; }
  
}
