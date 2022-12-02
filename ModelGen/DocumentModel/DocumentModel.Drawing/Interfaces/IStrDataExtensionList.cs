namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public interface IStrDataExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IStrDataExtension>? StrDataExtensions { get ; set; }
  
}
