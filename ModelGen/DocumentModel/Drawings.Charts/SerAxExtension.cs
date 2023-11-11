namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SerAxExtension Class.
/// </summary>
public partial class SerAxExtension: ModelElement<DXDC.SerAxExtension>
{
  public SerAxExtension(): base(){ }
  
  public SerAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SerAxExtension(DXDC.SerAxExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMDC13.NumberingFormat,DXO13DC.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.NumberingFormat,DXO13DC.NumberingFormat>(value);
    }
  }
  
}
