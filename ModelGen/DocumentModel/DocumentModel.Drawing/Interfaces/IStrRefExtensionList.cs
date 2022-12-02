namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public interface IStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IStrRefExtension>? StrRefExtensions { get ; set; }
  
}
