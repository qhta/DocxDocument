namespace DocumentModel.Office2021.Word.CommentsExt;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.Word.ExtensionList.IExtension>? Extensions { get ; set; }
  
}
