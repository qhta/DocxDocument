namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveBookmarkType Class.
/// </summary>
public partial class MoveBookmarkType: ModelElement<DXW.MoveBookmarkType>
{
  public MoveBookmarkType(): base(){ }
  
  public MoveBookmarkType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveBookmarkType(DXW.MoveBookmarkType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   author
  /// </summary>
  [DataMember]
  public String? Author
  {
    get => _Element?.Author;
    set => _ExistingElement.Author = value;
  }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [DataMember]
  public DateTime? Date
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   colFirst
  /// </summary>
  [DataMember]
  public Int32? ColumnFirst
  {
    get => _Element?.ColumnFirst?.Value;
    set => _ExistingElement.ColumnFirst = value;
  }
  
  
  /// <summary>
  ///   colLast
  /// </summary>
  [DataMember]
  public Int32? ColumnLast
  {
    get => _Element?.ColumnLast?.Value;
    set => _ExistingElement.ColumnLast = value;
  }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
