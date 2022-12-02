namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public interface IOfficeStyleSheetExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IOfficeStyleSheetExtension>? OfficeStyleSheetExtensions { get ; set; }
  
}
