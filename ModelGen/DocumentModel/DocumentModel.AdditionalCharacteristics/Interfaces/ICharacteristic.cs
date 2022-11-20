namespace DocumentModel.AdditionalCharacteristics;

/// <summary>
/// Single Characteristic.
/// </summary>
public interface ICharacteristic // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Name of Characteristic
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Relationship of Value to Name
  /// </summary>
  public RelationValues? Relation { get ; set; }
  
  /// <summary>
  /// Characteristic Value
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// Characteristic Grammar
  /// </summary>
  public string? Vocabulary { get ; set; }
  
}
