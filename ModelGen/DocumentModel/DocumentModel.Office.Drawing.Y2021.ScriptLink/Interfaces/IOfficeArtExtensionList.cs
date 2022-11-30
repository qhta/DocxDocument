namespace DocumentModel.Office.Drawing.Y2021.ScriptLink;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IExtension>? Extensions { get ; set; }
  
}
