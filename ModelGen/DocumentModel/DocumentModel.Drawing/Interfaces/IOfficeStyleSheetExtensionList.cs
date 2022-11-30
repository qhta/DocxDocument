namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public interface IOfficeStyleSheetExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IOfficeStyleSheetExtension>? OfficeStyleSheetExtensions { get ; set; }
  
}
