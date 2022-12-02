namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public interface IPieSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPieSerExtension>? PieSerExtensions { get ; set; }
  
}
