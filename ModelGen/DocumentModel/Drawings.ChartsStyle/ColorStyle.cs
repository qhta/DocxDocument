namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public partial class ColorStyle: ModelElement<DXO13DCS.ColorStyle>
{
  public ColorStyle(): base(){ }
  
  public ColorStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorStyle(DXO13DCS.ColorStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   meth, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Method
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Method);
    }
    set
    {
      _ExistingElement.Method = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  [DataMember]
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCS.OfficeArtExtensionList,DXO13DCS.OfficeArtExtensionList>(value);
    }
  }
  
}
