namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the StyleData Class.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleData))]
/// <summary>
/// Represents the Style Data.
/// </summary>
public class StyleData: SampleDataType
{
  /// <summary>
  /// Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}

