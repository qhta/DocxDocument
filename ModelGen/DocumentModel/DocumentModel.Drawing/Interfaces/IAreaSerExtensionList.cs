namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public interface IAreaSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAreaSerExtension>? AreaSerExtensions { get ; set; }
  
}
