namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public interface IPieSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPieSerExtension>? PieSerExtensions { get ; set; }
  
}
