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
      var element = _Element?.GetFirstChild<DXD.Dark1Color>();
      if (element != null)
        return Dark1ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Dark1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Dark1ColorConverter.CreateOpenXmlElement<DXD.Dark1Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Light1Color>();
      if (element != null)
        return Light1ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Light1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Light1ColorConverter.CreateOpenXmlElement<DXD.Light1Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Dark2Color>();
      if (element != null)
        return Dark2ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Dark2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Dark2ColorConverter.CreateOpenXmlElement<DXD.Dark2Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Light2Color>();
      if (element != null)
        return Light2ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Light2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Light2ColorConverter.CreateOpenXmlElement<DXD.Light2Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent1Color>();
      if (element != null)
        return Accent1ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent1ColorConverter.CreateOpenXmlElement<DXD.Accent1Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent2Color>();
      if (element != null)
        return Accent2ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent2ColorConverter.CreateOpenXmlElement<DXD.Accent2Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent3Color>();
      if (element != null)
        return Accent3ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent3Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent3ColorConverter.CreateOpenXmlElement<DXD.Accent3Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent4Color>();
      if (element != null)
        return Accent4ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent4Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent4ColorConverter.CreateOpenXmlElement<DXD.Accent4Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent5Color>();
      if (element != null)
        return Accent5ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent5Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent5ColorConverter.CreateOpenXmlElement<DXD.Accent5Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Accent6Color>();
      if (element != null)
        return Accent6ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Accent6Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Accent6ColorConverter.CreateOpenXmlElement<DXD.Accent6Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Hyperlink>();
      if (element != null)
        return HyperlinkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Hyperlink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkConverter.CreateOpenXmlElement<DXD.Hyperlink>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.FollowedHyperlinkColor>();
      if (element != null)
        return FollowedHyperlinkColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FollowedHyperlinkColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FollowedHyperlinkColorConverter.CreateOpenXmlElement<DXD.FollowedHyperlinkColor>(value);
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
