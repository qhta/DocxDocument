namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the root level complex type associated with a shared style sheet (or theme).  This element holds all the different formatting options available to a document through a theme and defines the overall look and feel of the document when themed objects are used within the document.
/// </summary>
public partial class Theme: ModelElement<DXD.Theme>
{
  public Theme(): base(){ }
  
  public Theme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Theme(DXD.Theme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the name given to the theme.
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
  public String? ThemeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeId);
    }
    set
    {
      _ExistingElement.ThemeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   ThemeElements.
  /// </summary>
  [DataMember]
  public DMD.ThemeElements? ThemeElements
  {
    get
    {
      return _Element?.GetObject<DMD.ThemeElements,DXD.ThemeElements>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ThemeElements,DXD.ThemeElements>(value);
    }
  }
  
  
  /// <summary>
  ///   ObjectDefaults.
  /// </summary>
  [DataMember]
  public DMD.ObjectDefaults? ObjectDefaults
  {
    get
    {
      return _Element?.GetObject<DMD.ObjectDefaults,DXD.ObjectDefaults>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ObjectDefaults,DXD.ObjectDefaults>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtraColorSchemeList.
  /// </summary>
  [DataMember]
  public DMD.ExtraColorSchemeList? ExtraColorSchemeList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtraColorSchemeList,DXD.ExtraColorSchemeList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtraColorSchemeList,DXD.ExtraColorSchemeList>(value);
    }
  }
  
  
  /// <summary>
  ///   CustomColorList.
  /// </summary>
  [DataMember]
  public DMD.CustomColorList? CustomColorList
  {
    get
    {
      return _Element?.GetObject<DMD.CustomColorList,DXD.CustomColorList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CustomColorList,DXD.CustomColorList>(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeStyleSheetExtensionList.
  /// </summary>
  [DataMember]
  public DMD.OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.OfficeStyleSheetExtensionList,DXD.OfficeStyleSheetExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.OfficeStyleSheetExtensionList,DXD.OfficeStyleSheetExtensionList>(value);
    }
  }
  
}
