namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BookmarkStart Class.
/// </summary>
public partial class BookmarkStart: ModelElement<DXW.BookmarkStart>
{
  public BookmarkStart(): base(){ }
  
  public BookmarkStart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BookmarkStart(DXW.BookmarkStart openXmlElement): base(openXmlElement) { }
  
  
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
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
