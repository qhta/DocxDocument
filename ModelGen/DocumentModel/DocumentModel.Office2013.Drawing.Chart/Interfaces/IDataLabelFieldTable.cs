namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public interface IDataLabelFieldTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTableEntry>? DataLabelFieldTableEntries { get ; set; }
  
}
