namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public partial class StrDataExtension: ModelElement<DXDC.StrDataExtension>
{
  public StrDataExtension(): base(){ }
  
  public StrDataExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrDataExtension(DXDC.StrDataExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.AutoGeneneratedCategories? AutoGeneneratedCategories
  {
    get
    {
      return _Element?.GetObject<DMDC13.AutoGeneneratedCategories,DXO13DC.AutoGeneneratedCategories>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.AutoGeneneratedCategories,DXO13DC.AutoGeneneratedCategories>(value);
    }
  }
  
}
