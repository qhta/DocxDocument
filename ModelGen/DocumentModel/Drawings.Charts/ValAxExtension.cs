namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public partial class ValAxExtension: ModelElement<DXDC.ValAxExtension>
{
  public ValAxExtension(): base(){ }
  
  public ValAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValAxExtension(DXDC.ValAxExtension openXmlElement): base(openXmlElement) { }
  
  
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
