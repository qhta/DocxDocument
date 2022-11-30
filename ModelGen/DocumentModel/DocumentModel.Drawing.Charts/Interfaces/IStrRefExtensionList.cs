namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public interface IStrRefExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStrRefExtension>? StrRefExtensions { get ; set; }
  
}
