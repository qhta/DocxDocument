namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public class BodyPropertiesImpl: ModelElementImpl, BodyProperties
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
    get => (Int32?)OpenXmlElement?.Rotation?.Value;
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
    get => (Boolean?)OpenXmlElement?.UseParagraphSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseParagraphSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow
  {
    get => (TextVerticalOverflowKind?)OpenXmlElement?.VerticalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalOverflow = (DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow
  {
    get => (TextHorizontalOverflowKind?)OpenXmlElement?.HorizontalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalOverflow = (DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public TextVerticalKind? Vertical
  {
    get => (TextVerticalKind?)OpenXmlElement?.Vertical?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Vertical = (DocumentFormat.OpenXml.Drawing.TextVerticalValues?)value;
    }
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public TextWrappingKind? Wrap
  {
    get => (TextWrappingKind?)OpenXmlElement?.Wrap?.Value;
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
    get => (Int32?)OpenXmlElement?.LeftInset?.Value;
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
    get => (Int32?)OpenXmlElement?.TopInset?.Value;
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
    get => (Int32?)OpenXmlElement?.RightInset?.Value;
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
    get => (Int32?)OpenXmlElement?.BottomInset?.Value;
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
    get => (Int32?)OpenXmlElement?.ColumnCount?.Value;
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
    get => (Int32?)OpenXmlElement?.ColumnSpacing?.Value;
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
    get => (Boolean?)OpenXmlElement?.RightToLeftColumns?.Value;
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
    get => (Boolean?)OpenXmlElement?.FromWordArt?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FromWordArt = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringKind? Anchor
  {
    get => (TextAnchoringKind?)OpenXmlElement?.Anchor?.Value;
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
    get => (Boolean?)OpenXmlElement?.AnchorCenter?.Value;
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
    get => (Boolean?)OpenXmlElement?.ForceAntiAlias?.Value;
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
    get => (Boolean?)OpenXmlElement?.UpRight?.Value;
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
    get => (Boolean?)OpenXmlElement?.CompatibleLineSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompatibleLineSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public PresetTextWrap? PresetTextWrap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public NormalAutoFit? NormalAutoFit
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public Scene3DType? Scene3DType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape3DType? Shape3DType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public FlatText? FlatText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
