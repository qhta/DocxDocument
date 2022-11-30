namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public interface ILineSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILineSerExtension>? LineSerExtensions { get ; set; }
  
}
