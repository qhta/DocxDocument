namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public interface IPieSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieSerExtension>? PieSerExtensions { get ; set; }
  
}
