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
      var element = _Element?.GetFirstChild<DXD.ThemeElements>();
      if (element != null)
        return ThemeElementsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ThemeElements>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ThemeElementsConverter.CreateOpenXmlElement<DXD.ThemeElements>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ObjectDefaults>();
      if (element != null)
        return ObjectDefaultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ObjectDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectDefaultsConverter.CreateOpenXmlElement<DXD.ObjectDefaults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ExtraColorSchemeList>();
      if (element != null)
        return ExtraColorSchemeListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtraColorSchemeList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtraColorSchemeListConverter.CreateOpenXmlElement<DXD.ExtraColorSchemeList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.CustomColorList>();
      if (element != null)
        return CustomColorListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CustomColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomColorListConverter.CreateOpenXmlElement<DXD.CustomColorList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
      if (element != null)
        return OfficeStyleSheetExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DXD.OfficeStyleSheetExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
