namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Properties.
/// </summary>
public partial class TablePropertiesChange: ModelElement<DXW.TablePropertiesChange>
{
  public TablePropertiesChange(): base(){ }
  
  public TablePropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TablePropertiesChange(DXW.TablePropertiesChange openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Previous Table Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousTableProperties? PreviousTableProperties
  {
    get
    {
      return _Element?.GetObject<DMW.PreviousTableProperties,DXW.PreviousTableProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PreviousTableProperties,DXW.PreviousTableProperties>(value);
    }
  }
  
}
