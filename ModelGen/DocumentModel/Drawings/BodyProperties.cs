namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the body properties for the text body within a shape.
/// </summary>
public partial class BodyProperties: ModelElement<DXD.BodyProperties>
{
  public BodyProperties(): base(){ }
  
  public BodyProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BodyProperties(DXD.BodyProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the rotation that is being applied to the text within the bounding box. If it not specified, the rotation of the accompanying shape is used. If it is specified, then this is applied independently from the shape. That is the shape can have a rotation applied in addition to the text itself having a rotation applied to it. If this attribute is omitted, then a value of 0, is implied.
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
  ///   Specifies whether the before and after paragraph spacing defined by the user is to be respected. While the spacing between paragraphs is helpful, it is additionally useful to be able to set a flag as to whether this spacing is to be followed at the edges of the text body, in other words the first and last paragraphs in the text body. More precisely since this is a text body level property it should only effect the before paragraph spacing of the first paragraph and the after paragraph spacing of the last paragraph for a given text body. If this attribute is omitted, then a value of 0, or false is implied.
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
  ///   Specifies the left inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 91440 or 0.1 inches is implied.
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
  ///   Specifies the top inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 45720 or 0.05 inches is implied.
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
  ///   Specifies the right inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 91440 or 0.1 inches is implied.
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
  ///   Specifies the bottom inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, a value of 45720 or 0.05 inches is implied.
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
  ///   Specifies the number of columns of text in the bounding rectangle. When applied to a text run this property takes the width of the bounding box for the text and divides it by the number of columns specified. These columns are then treated as overflow containers in that when the previous column has been filled with text the next column acts as the repository for additional text. When all columns have been filled and text still remains then the overflow properties set for this text body are used and the text is reflowed to make room for additional text. If this attribute is omitted, then a value of 1 is implied.
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
  ///   Specifies the space between text columns in the text area. This should only apply when there is more than 1 column present. If this attribute is omitted, then a value of 0 is implied.
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
  ///   Specifies whether columns are used in a right-to-left or left-to-right order. The usage of this attribute only sets the column order that is used to determine which column overflow text should go to next. If this attribute is omitted, then a value of 0 or false is implied in which case text starts in the leftmost column and flow to the right.
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
  ///   Specifies the centering of the text box. The way it works fundamentally is to determine the smallest possible &quot;bounds box&quot; for the text and then to center that &quot;bounds box&quot; accordingly. This is different than paragraph alignment, which aligns the text within the &quot;bounds box&quot; for the text. This flag is compatible with all of the different kinds of anchoring. If this attribute is omitted, then a value of 0 or false is implied.
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
  ///   Forces the text to be rendered anti-aliased regardless of the font size. Certain fonts can appear grainy around their edges unless they are anti-aliased. Therefore this attribute allows for the specifying of which bodies of text should always be anti-aliased and which ones should not. If this attribute is omitted, then a value of 0 or false is implied.
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
  ///   Specifies whether text should remain upright, regardless of the transform applied to it
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
