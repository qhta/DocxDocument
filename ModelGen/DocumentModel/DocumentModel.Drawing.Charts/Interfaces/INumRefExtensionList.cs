namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public interface INumRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.INumRefExtension>? NumRefExtensions { get ; set; }
  
}
