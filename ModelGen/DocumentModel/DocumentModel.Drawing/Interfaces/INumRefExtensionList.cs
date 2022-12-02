namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public interface INumRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INumRefExtension>? NumRefExtensions { get ; set; }
  
}
