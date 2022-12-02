namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public interface IDataLabelFieldTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataLabelFieldTableEntry>? DataLabelFieldTableEntries { get ; set; }
  
}
