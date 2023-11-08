namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextBodyProperties Class.
/// </summary>
public partial class TextBodyProperties: ModelElement<DXO13DCS.TextBodyProperties>
{
  public TextBodyProperties(): base(){ }
  
  public TextBodyProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBodyProperties(DXO13DCS.TextBodyProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get
    {
      return _Element?.Rotation?.Value;
    }
    set
    {
      _ExistingElement.Rotation = value;
    }
  }
  
  
  /// <summary>
  ///   Paragraph Spacing
  /// </summary>
  [DataMember]
  public Boolean? UseParagraphSpacing
  {
    get
    {
      return _Element?.UseParagraphSpacing?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UseParagraphSpacing = null;
    }
  }
  
  
  /// <summary>
  ///   Left Inset
  /// </summary>
  [DataMember]
  public Int32? LeftInset
  {
    get
    {
      return _Element?.LeftInset?.Value;
    }
    set
    {
      _ExistingElement.LeftInset = value;
    }
  }
  
  
  /// <summary>
  ///   Top Inset
  /// </summary>
  [DataMember]
  public Int32? TopInset
  {
    get
    {
      return _Element?.TopInset?.Value;
    }
    set
    {
      _ExistingElement.TopInset = value;
    }
  }
  
  
  /// <summary>
  ///   Right Inset
  /// </summary>
  [DataMember]
  public Int32? RightInset
  {
    get
    {
      return _Element?.RightInset?.Value;
    }
    set
    {
      _ExistingElement.RightInset = value;
    }
  }
  
  
  /// <summary>
  ///   Bottom Inset
  /// </summary>
  [DataMember]
  public Int32? BottomInset
  {
    get
    {
      return _Element?.BottomInset?.Value;
    }
    set
    {
      _ExistingElement.BottomInset = value;
    }
  }
  
  
  /// <summary>
  ///   Number of Columns
  /// </summary>
  [DataMember]
  public Int32? ColumnCount
  {
    get
    {
      return _Element?.ColumnCount?.Value;
    }
    set
    {
      _ExistingElement.ColumnCount = value;
    }
  }
  
  
  /// <summary>
  ///   Space Between Columns
  /// </summary>
  [DataMember]
  public Int32? ColumnSpacing
  {
    get
    {
      return _Element?.ColumnSpacing?.Value;
    }
    set
    {
      _ExistingElement.ColumnSpacing = value;
    }
  }
  
  
  /// <summary>
  ///   Columns Right-To-Left
  /// </summary>
  [DataMember]
  public Boolean? RightToLeftColumns
  {
    get
    {
      return _Element?.RightToLeftColumns?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.RightToLeftColumns = null;
    }
  }
  
  
  /// <summary>
  ///   From WordArt
  /// </summary>
  [DataMember]
  public Boolean? FromWordArt
  {
    get
    {
      return _Element?.FromWordArt?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.FromWordArt = null;
    }
  }
  
  
  /// <summary>
  ///   Anchor Center
  /// </summary>
  [DataMember]
  public Boolean? AnchorCenter
  {
    get
    {
      return _Element?.AnchorCenter?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.AnchorCenter = null;
    }
  }
  
  
  /// <summary>
  ///   Force Anti-Alias
  /// </summary>
  [DataMember]
  public Boolean? ForceAntiAlias
  {
    get
    {
      return _Element?.ForceAntiAlias?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ForceAntiAlias = null;
    }
  }
  
  
  /// <summary>
  ///   Text Upright
  /// </summary>
  [DataMember]
  public Boolean? UpRight
  {
    get
    {
      return _Element?.UpRight?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UpRight = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UpRight = null;
    }
  }
  
  
  /// <summary>
  ///   Compatible Line Spacing
  /// </summary>
  [DataMember]
  public Boolean? CompatibleLineSpacing
  {
    get
    {
      return _Element?.CompatibleLineSpacing?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.CompatibleLineSpacing = null;
    }
  }
  
  
  /// <summary>
  ///   Preset Text Shape.
  /// </summary>
  [DataMember]
  public DMD.PresetTextWrap? PresetTextWrap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PresetTextWrap>();
      if (element != null)
        return PresetTextWrapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PresetTextWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetTextWrapConverter.CreateOpenXmlElement<DXD.PresetTextWrap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.NoAutoFit? NoAutoFit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoAutoFit>();
      if (element != null)
        return NoAutoFitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoAutoFitConverter.CreateOpenXmlElement<DXD.NoAutoFit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.NormalAutoFit? NormalAutoFit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NormalAutoFit>();
      if (element != null)
        return NormalAutoFitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NormalAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NormalAutoFitConverter.CreateOpenXmlElement<DXD.NormalAutoFit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ShapeAutoFit? ShapeAutoFit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapeAutoFit>();
      if (element != null)
        return ShapeAutoFitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeAutoFitConverter.CreateOpenXmlElement<DXD.ShapeAutoFit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Scene3DType>();
      if (element != null)
        return Scene3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Scene3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Shape3DType>();
      if (element != null)
        return Shape3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.FlatText? FlatText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FlatText>();
      if (element != null)
        return FlatTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FlatText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FlatTextConverter.CreateOpenXmlElement<DXD.FlatText>(value);
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
