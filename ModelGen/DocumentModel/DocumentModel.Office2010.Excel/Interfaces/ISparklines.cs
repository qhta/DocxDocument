namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Sparklines Class.
/// </summary>
public interface ISparklines // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ISparkline>? Sparklines { get ; set; }
  
}
