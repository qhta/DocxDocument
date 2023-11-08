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
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   colFirst
  /// </summary>
  [DataMember]
  public Int32? ColumnFirst
  {
    get
    {
      return _Element?.ColumnFirst?.Value;
    }
    set
    {
      _ExistingElement.ColumnFirst = value;
    }
  }
  
  
  /// <summary>
  ///   colLast
  /// </summary>
  [DataMember]
  public Int32? ColumnLast
  {
    get
    {
      return _Element?.ColumnLast?.Value;
    }
    set
    {
      _ExistingElement.ColumnLast = value;
    }
  }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
