namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public interface INumRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<INumRefExtension>? NumRefExtensions { get ; set; }
  
}
