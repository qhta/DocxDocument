namespace DocumentModel.Theme;


/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public partial class ThemeFamily: ModelElement<DXO13T.ThemeFamily>
{
  public ThemeFamily(): base(){ }
  
  public ThemeFamily(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeFamily(DXO13T.ThemeFamily openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
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
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Vid
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Vid);
    }
    set
    {
      _ExistingElement.Vid = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMT.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMT.OfficeArtExtensionList,DXO13T.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMT.OfficeArtExtensionList,DXO13T.OfficeArtExtensionList>(value);
    }
  }
  
}
