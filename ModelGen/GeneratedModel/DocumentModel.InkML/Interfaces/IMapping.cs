namespace DocumentModel.InkML;

/// <summary>
/// Defines the Mapping Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IBind))]
[ChildElementInfo(typeof(DocumentModel.InkML.IMapping))]
[ChildElementInfo(typeof(DocumentModel.InkML.IMatrix))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITable))]
public interface IMapping // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public MappingType? Type { get ; set; }
  
  /// <summary>
  /// mappingRef
  /// </summary>
  public string? MappingRef { get ; set; }
  
}
