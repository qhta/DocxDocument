namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the SampleData Class.
/// </summary>
[OpenXmlType(typeof(DXDD.SampleData))]
public class SampleData: SampleDataType
{
  public DataModel? DataModel { get; set; }
}