namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the StyleData Class.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleData))]
public class StyleData: SampleDataType
{
  public DataModel? DataModel { get; set; }
}