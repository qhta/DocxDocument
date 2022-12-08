namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public class DataLabelFieldTableImpl: ModelElementImpl, DataLabelFieldTable
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DataLabelFieldTableEntry>? DataLabelFieldTableEntries
  {
    get;
    set;
  }
  
}
