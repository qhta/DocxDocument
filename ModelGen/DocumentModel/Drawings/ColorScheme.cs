namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of colors which are referred to as a color scheme.  The color scheme is responsible for defining a list of twelve colors.  The twelve colors consist of six accent colors, two dark colors, two light colors and a color for each of a hyperlink and followed hyperlink.
/// </summary>
public partial class ColorScheme: ModelElement<DXD.ColorScheme>
{
  public ColorScheme(): base(){ }
  
  public ColorScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorScheme(DXD.ColorScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   The common name for this color scheme.  This name can show up in the user interface in a list of color schemes.
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
  ///   Dark 1.
  /// </summary>
  [DataMember]
  public DMD.Dark1Color? Dark1Color
  {
    get
    {
      return _Element?.GetObject<DMD.Dark1Color,DXD.Dark1Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Dark1Color,DXD.Dark1Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Light 1.
  /// </summary>
  [DataMember]
  public DMD.Light1Color? Light1Color
  {
    get
    {
      return _Element?.GetObject<DMD.Light1Color,DXD.Light1Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Light1Color,DXD.Light1Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Dark 2.
  /// </summary>
  [DataMember]
  public DMD.Dark2Color? Dark2Color
  {
    get
    {
      return _Element?.GetObject<DMD.Dark2Color,DXD.Dark2Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Dark2Color,DXD.Dark2Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Light 2.
  /// </summary>
  [DataMember]
  public DMD.Light2Color? Light2Color
  {
    get
    {
      return _Element?.GetObject<DMD.Light2Color,DXD.Light2Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Light2Color,DXD.Light2Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 1.
  /// </summary>
  [DataMember]
  public DMD.Accent1Color? Accent1Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent1Color,DXD.Accent1Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent1Color,DXD.Accent1Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 2.
  /// </summary>
  [DataMember]
  public DMD.Accent2Color? Accent2Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent2Color,DXD.Accent2Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent2Color,DXD.Accent2Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 3.
  /// </summary>
  [DataMember]
  public DMD.Accent3Color? Accent3Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent3Color,DXD.Accent3Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent3Color,DXD.Accent3Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 4.
  /// </summary>
  [DataMember]
  public DMD.Accent4Color? Accent4Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent4Color,DXD.Accent4Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent4Color,DXD.Accent4Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 5.
  /// </summary>
  [DataMember]
  public DMD.Accent5Color? Accent5Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent5Color,DXD.Accent5Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent5Color,DXD.Accent5Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Accent 6.
  /// </summary>
  [DataMember]
  public DMD.Accent6Color? Accent6Color
  {
    get
    {
      return _Element?.GetObject<DMD.Accent6Color,DXD.Accent6Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Accent6Color,DXD.Accent6Color>(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink.
  /// </summary>
  [DataMember]
  public DMD.Hyperlink? Hyperlink
  {
    get
    {
      return _Element?.GetObject<DMD.Hyperlink,DXD.Hyperlink>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Hyperlink,DXD.Hyperlink>(value);
    }
  }
  
  
  /// <summary>
  ///   Followed Hyperlink.
  /// </summary>
  [DataMember]
  public DMD.FollowedHyperlinkColor? FollowedHyperlinkColor
  {
    get
    {
      return _Element?.GetObject<DMD.FollowedHyperlinkColor,DXD.FollowedHyperlinkColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FollowedHyperlinkColor,DXD.FollowedHyperlinkColor>(value);
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
