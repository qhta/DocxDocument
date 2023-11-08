namespace DocumentModel.Drawings;


/// <summary>
///   This element contains the background fill styles, effect styles, fill styles, and line styles which define the style matrix for a theme.  The style matrix consists of subtle, moderate, and intense fills, lines, and effects.  The background fills are not generally thought of to directly be associated with the matrix, but do play a role in the style of the overall document.  Usually, a given object chooses a single line style, a single fill style, and a single effect style in order to define the overall final look of the object.
/// </summary>
public partial class FormatScheme: ModelElement<DXD.FormatScheme>
{
  public FormatScheme(): base(){ }
  
  public FormatScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormatScheme(DXD.FormatScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Defines the name for the format scheme.  The name is simply a human readable string which identifies the format scheme in the user interface.
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
  ///   Fill Style List.
  /// </summary>
  [DataMember]
  public DMD.FillStyleList? FillStyleList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FillStyleList>();
      if (element != null)
        return FillStyleListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FillStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillStyleListConverter.CreateOpenXmlElement<DXD.FillStyleList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Line Style List.
  /// </summary>
  [DataMember]
  public DMD.LineStyleList? LineStyleList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineStyleList>();
      if (element != null)
        return LineStyleListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineStyleListConverter.CreateOpenXmlElement<DXD.LineStyleList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Effect Style List.
  /// </summary>
  [DataMember]
  public DMD.EffectStyleList? EffectStyleList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectStyleList>();
      if (element != null)
        return EffectStyleListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectStyleListConverter.CreateOpenXmlElement<DXD.EffectStyleList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Background Fill Style List.
  /// </summary>
  [DataMember]
  public DMD.BackgroundFillStyleList? BackgroundFillStyleList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BackgroundFillStyleList>();
      if (element != null)
        return BackgroundFillStyleListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BackgroundFillStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundFillStyleListConverter.CreateOpenXmlElement<DXD.BackgroundFillStyleList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
