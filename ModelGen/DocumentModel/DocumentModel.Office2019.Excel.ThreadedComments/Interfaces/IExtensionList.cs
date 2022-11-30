namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IExtension>? Extensions { get ; set; }
  
}
