namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public partial class ParagraphMarkRunPropertiesChange: ModelElement<DXW.ParagraphMarkRunPropertiesChange>
{
  public ParagraphMarkRunPropertiesChange(): base(){ }
  
  public ParagraphMarkRunPropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphMarkRunPropertiesChange(DXW.ParagraphMarkRunPropertiesChange openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Previous Run Properties for the Paragraph Mark.
  /// </summary>
  [DataMember]
  public DMW.PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.PreviousParagraphMarkRunProperties,DXW.PreviousParagraphMarkRunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PreviousParagraphMarkRunProperties,DXW.PreviousParagraphMarkRunProperties>(value);
    }
  }
  
}
