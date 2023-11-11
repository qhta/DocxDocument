namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the InsertedMathControl Class.
/// </summary>
public partial class InsertedMathControl: ModelElement<DXW.InsertedMathControl>
{
  public InsertedMathControl(): base(){ }
  
  public InsertedMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InsertedMathControl(DXW.InsertedMathControl openXmlElement): base(openXmlElement) { }
  
  
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
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.RunProperties,DXW.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunProperties,DXW.RunProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.DeletedMathControl? DeletedMathControl
  {
    get
    {
      return _Element?.GetObject<DMW.DeletedMathControl,DXW.DeletedMathControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DeletedMathControl,DXW.DeletedMathControl>(value);
    }
  }
  
}
