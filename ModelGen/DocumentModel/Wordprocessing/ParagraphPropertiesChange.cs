namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ParagraphPropertiesChange Class.
/// </summary>
public partial class ParagraphPropertiesChange: ModelElement<DXW.ParagraphPropertiesChange>
{
  public ParagraphPropertiesChange(): base(){ }
  
  public ParagraphPropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphPropertiesChange(DXW.ParagraphPropertiesChange openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   Previous Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesExtended? ParagraphPropertiesExtended
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphPropertiesExtended,DXW.ParagraphPropertiesExtended>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphPropertiesExtended,DXW.ParagraphPropertiesExtended>(value);
    }
  }
  
}
