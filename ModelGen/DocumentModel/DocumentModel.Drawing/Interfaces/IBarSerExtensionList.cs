namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public interface IBarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBarSerExtension>? BarSerExtensions { get ; set; }
  
}
