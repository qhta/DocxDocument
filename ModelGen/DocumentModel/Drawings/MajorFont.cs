namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont: ModelElement<DXD.MajorFont>
{
  public MajorFont(): base(){ }
  
  public MajorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorFont(DXD.MajorFont openXmlElement): base(openXmlElement) { }
  
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
