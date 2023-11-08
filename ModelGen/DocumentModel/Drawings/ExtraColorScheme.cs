namespace DocumentModel.Drawings;


/// <summary>
///   This element defines an auxiliary color scheme, which includes both a color scheme and color mapping.  This is mainly used for backward compatibility concerns and roundtrips information required by earlier versions.
/// </summary>
public partial class ExtraColorScheme: ModelElement<DXD.ExtraColorScheme>
{
  public ExtraColorScheme(): base(){ }
  
  public ExtraColorScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtraColorScheme(DXD.ExtraColorScheme openXmlElement): base(openXmlElement) { }
  
  
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
  ///   ColorMap.
  /// </summary>
  [DataMember]
  public DMD.ColorMap? ColorMap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ColorMap>();
      if (element != null)
        return ColorMapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ColorMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMapConverter.CreateOpenXmlElement<DXD.ColorMap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
