namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Hyperlinks Class.
/// </summary>
public interface IHyperlinks // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IHyperlink>? Hyperlinks { get ; set; }
  
}
