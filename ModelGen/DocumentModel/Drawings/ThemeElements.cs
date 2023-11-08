namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the theme formatting options for the theme and is the workhorse of the theme.  This is where the bulk of the shared theme information is contained and used by a document.  This element contains the color scheme, font scheme, and format scheme elements which define the different formatting aspects of what a theme defines.
/// </summary>
public partial class ThemeElements: ModelElement<DXD.ThemeElements>
{
  public ThemeElements(): base(){ }
  
  public ThemeElements(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeElements(DXD.ThemeElements openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  [DataMember]
  public DMD.ColorScheme? ColorScheme
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ColorScheme>();
      if (element != null)
        return ColorSchemeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ColorScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorSchemeConverter.CreateOpenXmlElement<DXD.ColorScheme>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Font Scheme.
  /// </summary>
  [DataMember]
  public DMD.FontScheme? FontScheme
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FontScheme>();
      if (element != null)
        return FontSchemeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FontScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSchemeConverter.CreateOpenXmlElement<DXD.FontScheme>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Format Scheme.
  /// </summary>
  [DataMember]
  public DMD.FormatScheme? FormatScheme
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FormatScheme>();
      if (element != null)
        return FormatSchemeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FormatScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatSchemeConverter.CreateOpenXmlElement<DXD.FormatScheme>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
