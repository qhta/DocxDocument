namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public interface IAreaSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IAreaSerExtension>? AreaSerExtensions { get ; set; }
  
}
