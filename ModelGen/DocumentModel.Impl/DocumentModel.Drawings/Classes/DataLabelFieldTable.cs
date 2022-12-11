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
  
  public DataLabelFieldTableImpl(): base() {}
  
  public DataLabelFieldTableImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DataLabelFieldTableEntry>? DataLabelFieldTableEntries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
