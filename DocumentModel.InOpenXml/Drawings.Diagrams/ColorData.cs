namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the ColorData Class.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorData))]
/// <summary>
/// Represents the Color Data.
/// </summary>
public class ColorData: SampleDataType
{
  /// <summary>
  /// Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}

