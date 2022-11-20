namespace DocumentModel.InkML;

/// <summary>
/// Defines the Mapping Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IBind))]
[ChildElementInfo(typeof(DocumentModel.InkML.IMapping))]
[ChildElementInfo(typeof(DocumentModel.InkML.IMatrix))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITable))]
public class Mapping: IMapping
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public MappingTypeValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// mappingRef
  /// </summary>
  public string? MappingRef
  {
    get;
    set;
  }
  
}
