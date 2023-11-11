namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the CatAxExtension Class.
/// </summary>
public partial class CatAxExtension: ModelElement<DXDC.CatAxExtension>
{
  public CatAxExtension(): base(){ }
  
  public CatAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CatAxExtension(DXDC.CatAxExtension openXmlElement): base(openXmlElement) { }
  
  
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
