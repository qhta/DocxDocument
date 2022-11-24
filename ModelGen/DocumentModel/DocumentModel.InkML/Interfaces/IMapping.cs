namespace DocumentModel.InkML;

/// <summary>
/// Defines the Mapping Class.
/// </summary>
public interface IMapping // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public MappingTypeValues? Type { get ; set; }
  
  /// <summary>
  /// mappingRef
  /// </summary>
  public String? MappingRef { get ; set; }
  
}
