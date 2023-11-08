namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the font scheme within the theme.  The font scheme consists of a pair of major and minor fonts for which to use in a document.  The major font corresponds well with the heading areas of a document, and the minor font corresponds well with the normal text or paragraph areas.
/// </summary>
public partial class FontScheme: ModelElement<DXD.FontScheme>
{
  public FontScheme(): base(){ }
  
  public FontScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontScheme(DXD.FontScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   The name of the font scheme shown in the user interface.
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
  ///   Major Font.
  /// </summary>
  [DataMember]
  public DMD.MajorFont? MajorFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.MajorFont>();
      if (element != null)
        return MajorFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.MajorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorFontConverter.CreateOpenXmlElement<DXD.MajorFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Minor fonts.
  /// </summary>
  [DataMember]
  public DMD.MinorFont? MinorFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.MinorFont>();
      if (element != null)
        return MinorFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.MinorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorFontConverter.CreateOpenXmlElement<DXD.MinorFont>(value);
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
