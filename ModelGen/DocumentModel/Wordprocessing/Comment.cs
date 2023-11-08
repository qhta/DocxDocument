namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comment Content.
/// </summary>
public partial class Comment: ModelElement<DXW.Comment>
{
  public Comment(): base(){ }
  
  public Comment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Comment(DXW.Comment openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   initials
  /// </summary>
  [DataMember]
  public String? Initials
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Initials);
    }
    set
    {
      _ExistingElement.Initials = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
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
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public DateTime? DateUtc
  {
    get
    {
      return _Element?.DateUtc?.Value;
    }
    set
    {
      _ExistingElement.DateUtc = value;
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
