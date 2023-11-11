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
        _ExistingElement.UseParagraphSpacing = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.RightToLeftColumns = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.FromWordArt = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.AnchorCenter = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.ForceAntiAlias = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.UpRight = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.CompatibleLineSpacing = new DX.BooleanValue { Value = (Boolean)value };
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
      return _Element?.GetObject<DMD.PresetTextWrap,DXD.PresetTextWrap>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PresetTextWrap,DXD.PresetTextWrap>(value);
    }
  }
  
  [DataMember]
  public DMD.NoAutoFit? NoAutoFit
  {
    get
    {
      return _Element?.GetObject<DMD.NoAutoFit,DXD.NoAutoFit>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoAutoFit,DXD.NoAutoFit>(value);
    }
  }
  
  [DataMember]
  public DMD.NormalAutoFit? NormalAutoFit
  {
    get
    {
      return _Element?.GetObject<DMD.NormalAutoFit,DXD.NormalAutoFit>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NormalAutoFit,DXD.NormalAutoFit>(value);
    }
  }
  
  [DataMember]
  public DMD.ShapeAutoFit? ShapeAutoFit
  {
    get
    {
      return _Element?.GetObject<DMD.ShapeAutoFit,DXD.ShapeAutoFit>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeAutoFit,DXD.ShapeAutoFit>(value);
    }
  }
  
  [DataMember]
  public DMD.Scene3DType? Scene3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Scene3DType,DXD.Scene3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Scene3DType,DXD.Scene3DType>(value);
    }
  }
  
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      return _Element?.GetObject<DMD.Shape3DType,DXD.Shape3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Shape3DType,DXD.Shape3DType>(value);
    }
  }
  
  [DataMember]
  public DMD.FlatText? FlatText
  {
    get
    {
      return _Element?.GetObject<DMD.FlatText,DXD.FlatText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FlatText,DXD.FlatText>(value);
    }
  }
  
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
