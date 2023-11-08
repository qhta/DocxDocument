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
    get
    {
      return StringValueConverter.GetValue(_Element?.Author);
    }
    set
    {
      _ExistingElement.Author = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [DataMember]
  public DateTime? Date
  {
    get
    {
      return _Element?.Date?.Value;
    }
    set
    {
      _ExistingElement.Date = value;
    }
  }
  
  
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
