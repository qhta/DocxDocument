namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.SampleDataType))]
public class SampleDataType: ModelElement<DXDD.SampleDataType>
{
  /// <summary>
  ///   Use Default
  /// </summary>
  public bool? UseDefault { get; set; }
  /// <summary>
  ///   Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}