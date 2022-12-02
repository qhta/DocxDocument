namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public interface IDataLabelFieldTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDataLabelFieldTableEntry>? DataLabelFieldTableEntries { get ; set; }
  
}
