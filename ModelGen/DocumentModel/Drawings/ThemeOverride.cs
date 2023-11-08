namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for an override which changes just the colors, fonts, or effects of a single object, like a table for example.  Currently it is used only to control overrides on the non-top-level masters within a presentation.
/// </summary>
public partial class ThemeOverride: ModelElement<DXD.ThemeOverride>
{
  public ThemeOverride(): base(){ }
  
  public ThemeOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeOverride(DXD.ThemeOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Color Scheme.
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
  ///   FontScheme.
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
  ///   FormatScheme.
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
  
}
