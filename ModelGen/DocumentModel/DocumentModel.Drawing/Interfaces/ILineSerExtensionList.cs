namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public interface ILineSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ILineSerExtension>? LineSerExtensions { get ; set; }
  
}
