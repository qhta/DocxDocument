namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public interface IScatterSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IScatterSerExtension>? ScatterSerExtensions { get ; set; }
  
}
