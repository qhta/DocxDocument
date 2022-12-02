namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public interface IAreaSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAreaSerExtension>? AreaSerExtensions { get ; set; }
  
}
