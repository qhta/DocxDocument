namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public interface IStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStrRefExtension>? StrRefExtensions { get ; set; }
  
}
