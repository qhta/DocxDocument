namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public interface ILineSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILineSerExtension>? LineSerExtensions { get ; set; }
  
}
