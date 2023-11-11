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
      return _Element?.GetObject<DMD.MajorFont,DXD.MajorFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.MajorFont,DXD.MajorFont>(value);
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
      return _Element?.GetObject<DMD.MinorFont,DXD.MinorFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.MinorFont,DXD.MinorFont>(value);
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
