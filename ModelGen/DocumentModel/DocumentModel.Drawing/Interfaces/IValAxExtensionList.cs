namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public interface IValAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IValAxExtension>? ValAxExtensions { get ; set; }
  
}
