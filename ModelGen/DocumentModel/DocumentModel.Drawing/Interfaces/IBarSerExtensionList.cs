namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public interface IBarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBarSerExtension>? BarSerExtensions { get ; set; }
  
}
