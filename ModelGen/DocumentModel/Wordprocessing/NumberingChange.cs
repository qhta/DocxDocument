namespace DocumentModel.Wordprocessing;


/// <summary>
///   Previous Paragraph Numbering Properties.
/// </summary>
public partial class NumberingChange: ModelElement<DXW.NumberingChange>
{
  public NumberingChange(): base(){ }
  
  public NumberingChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingChange(DXW.NumberingChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   original
  /// </summary>
  [DataMember]
  public String? Original
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Original);
    }
    set
    {
      _ExistingElement.Original = StringValueConverter.CreateStringValue(value);
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
