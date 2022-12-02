namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Sparklines Class.
/// </summary>
public interface ISparklines // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISparkline>? Sparklines { get ; set; }
  
}
