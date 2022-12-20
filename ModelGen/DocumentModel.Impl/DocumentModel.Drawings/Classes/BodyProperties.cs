namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public partial class BodyPropertiesImpl: ModelElementImpl, BodyProperties
{
  public DocumentFormat.OpenXml.Drawing.BodyProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BodyProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BodyPropertiesImpl(): base() {}
  
  public BodyPropertiesImpl(DocumentFormat.OpenXml.Drawing.BodyProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation
  {
    get => (System.Int32?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public Boolean? UseParagraphSpacing
  {
    get => (System.Boolean?)OpenXmlElement?.UseParagraphSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseParagraphSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public DocumentModel.Drawings.TextVerticalOverflowKind? VerticalOverflow
  {
    get => (DocumentModel.Drawings.TextVerticalOverflowKind?)OpenXmlElement?.VerticalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalOverflow = (DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public DocumentModel.Drawings.TextHorizontalOverflowKind? HorizontalOverflow
  {
    get => (DocumentModel.Drawings.TextHorizontalOverflowKind?)OpenXmlElement?.HorizontalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalOverflow = (DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public DocumentModel.Drawings.TextVerticalKind? Vertical
  {
    get => (DocumentModel.Drawings.TextVerticalKind?)OpenXmlElement?.Vertical?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Vertical = (DocumentFormat.OpenXml.Drawing.TextVerticalValues?)value;
    }
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public DocumentModel.Drawings.TextWrappingKind? Wrap
  {
    get => (DocumentModel.Drawings.TextWrappingKind?)OpenXmlElement?.Wrap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Wrap = (DocumentFormat.OpenXml.Drawing.TextWrappingValues?)value;
    }
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public Int32? LeftInset
  {
    get => (System.Int32?)OpenXmlElement?.LeftInset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeftInset = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public Int32? TopInset
  {
    get => (System.Int32?)OpenXmlElement?.TopInset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TopInset = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public Int32? RightInset
  {
    get => (System.Int32?)OpenXmlElement?.RightInset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightInset = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public Int32? BottomInset
  {
    get => (System.Int32?)OpenXmlElement?.BottomInset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BottomInset = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public Int32? ColumnCount
  {
    get => (System.Int32?)OpenXmlElement?.ColumnCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnCount = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public Int32? ColumnSpacing
  {
    get => (System.Int32?)OpenXmlElement?.ColumnSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnSpacing = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public Boolean? RightToLeftColumns
  {
    get => (System.Boolean?)OpenXmlElement?.RightToLeftColumns?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightToLeftColumns = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public Boolean? FromWordArt
  {
    get => (System.Boolean?)OpenXmlElement?.FromWordArt?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FromWordArt = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public DocumentModel.Drawings.TextAnchoringKind? Anchor
  {
    get => (DocumentModel.Drawings.TextAnchoringKind?)OpenXmlElement?.Anchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Anchor = (DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public Boolean? AnchorCenter
  {
    get => (System.Boolean?)OpenXmlElement?.AnchorCenter?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorCenter = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public Boolean? ForceAntiAlias
  {
    get => (System.Boolean?)OpenXmlElement?.ForceAntiAlias?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForceAntiAlias = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public Boolean? UpRight
  {
    get => (System.Boolean?)OpenXmlElement?.UpRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UpRight = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public Boolean? CompatibleLineSpacing
  {
    get => (System.Boolean?)OpenXmlElement?.CompatibleLineSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompatibleLineSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public DocumentModel.Drawings.PresetTextWrap? PresetTextWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
        if (item != null)
          return new DocumentModel.Drawings.PresetTextWrapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PresetTextWrapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? NoAutoFit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.NoAutoFit();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.NormalAutoFit? NormalAutoFit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
        if (item != null)
          return new DocumentModel.Drawings.NormalAutoFitImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.NormalAutoFitImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? ShapeAutoFit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.ShapeAutoFit();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
        if (item != null)
          return new DocumentModel.Drawings.Scene3DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Scene3DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
        if (item != null)
          return new DocumentModel.Drawings.Shape3DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Shape3DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.FlatText? FlatText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
        if (item != null)
          return new DocumentModel.Drawings.FlatTextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.FlatTextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
