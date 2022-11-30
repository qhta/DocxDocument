namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public interface ICatAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ICatAxExtension>? CatAxExtensions { get ; set; }
  
}
