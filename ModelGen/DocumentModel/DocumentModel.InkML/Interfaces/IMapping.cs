namespace DocumentModel.InkML;

/// <summary>
/// Defines the Mapping Class.
/// </summary>
public interface IMapping // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.InkML.MappingTypeKind? Type { get ; set; }
  
  /// <summary>
  /// mappingRef
  /// </summary>
  public System.String? MappingRef { get ; set; }
  
}
