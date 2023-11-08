namespace DocumentModel.Drawings;


/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType: ModelElement<DXD.FontCollectionType>
{
  public FontCollectionType(): base(){ }
  
  public FontCollectionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontCollectionType(DXD.FontCollectionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Latin Font.
  /// </summary>
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LatinFont>();
      if (element != null)
        return LatinFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LatinFontConverter.CreateOpenXmlElement<DXD.LatinFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EastAsianFont>();
      if (element != null)
        return EastAsianFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EastAsianFontConverter.CreateOpenXmlElement<DXD.EastAsianFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ComplexScriptFont>();
      if (element != null)
        return ComplexScriptFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ComplexScriptFontConverter.CreateOpenXmlElement<DXD.ComplexScriptFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
