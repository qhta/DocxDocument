namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public interface IBarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBarSerExtension>? BarSerExtensions { get ; set; }
  
}
