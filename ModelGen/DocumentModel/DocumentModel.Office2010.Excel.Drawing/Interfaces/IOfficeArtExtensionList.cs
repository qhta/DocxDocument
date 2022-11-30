namespace DocumentModel.Office2010.Excel.Drawing;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IExtension>? Extensions { get ; set; }
  
}
