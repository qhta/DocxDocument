namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the SampleData Class.
/// </summary>
[OpenXmlType(typeof(DXDD.SampleData))]
/// <summary>
/// Represents the Sample Data.
/// </summary>
public class SampleData: SampleDataType
{
  /// <summary>
  /// Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}

