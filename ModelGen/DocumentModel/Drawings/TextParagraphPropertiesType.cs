namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextParagraphPropertiesType Class.
/// </summary>
public partial class TextParagraphPropertiesType: ModelElement<DXD.TextParagraphPropertiesType>
{
  public TextParagraphPropertiesType(): base(){ }
  
  public TextParagraphPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextParagraphPropertiesType(DXD.TextParagraphPropertiesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Left Margin
  /// </summary>
  [DataMember]
  public Int32? LeftMargin
  {
    get
    {
      return _Element?.LeftMargin?.Value;
    }
    set
    {
      _ExistingElement.LeftMargin = value;
    }
  }
  
  
  /// <summary>
  ///   Right Margin
  /// </summary>
  [DataMember]
  public Int32? RightMargin
  {
    get
    {
      return _Element?.RightMargin?.Value;
    }
    set
    {
      _ExistingElement.RightMargin = value;
    }
  }
  
  
  /// <summary>
  ///   Level
  /// </summary>
  [DataMember]
  public Int32? Level
  {
    get
    {
      return _Element?.Level?.Value;
    }
    set
    {
      _ExistingElement.Level = value;
    }
  }
  
  
  /// <summary>
  ///   Indent
  /// </summary>
  [DataMember]
  public Int32? Indent
  {
    get
    {
      return _Element?.Indent?.Value;
    }
    set
    {
      _ExistingElement.Indent = value;
    }
  }
  
  
  /// <summary>
  ///   Default Tab Size
  /// </summary>
  [DataMember]
  public Int32? DefaultTabSize
  {
    get
    {
      return _Element?.DefaultTabSize?.Value;
    }
    set
    {
      _ExistingElement.DefaultTabSize = value;
    }
  }
  
  
  /// <summary>
  ///   Right To Left
  /// </summary>
  [DataMember]
  public Boolean? RightToLeft
  {
    get
    {
      return _Element?.RightToLeft?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.RightToLeft = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.RightToLeft = null;
    }
  }
  
  
  /// <summary>
  ///   East Asian Line Break
  /// </summary>
  [DataMember]
  public Boolean? EastAsianLineBreak
  {
    get
    {
      return _Element?.EastAsianLineBreak?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.EastAsianLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.EastAsianLineBreak = null;
    }
  }
  
  
  /// <summary>
  ///   Latin Line Break
  /// </summary>
  [DataMember]
  public Boolean? LatinLineBreak
  {
    get
    {
      return _Element?.LatinLineBreak?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LatinLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LatinLineBreak = null;
    }
  }
  
  
  /// <summary>
  ///   Hanging Punctuation
  /// </summary>
  [DataMember]
  public Boolean? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Height = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Height = null;
    }
  }
  
  
  /// <summary>
  ///   Line Spacing.
  /// </summary>
  [DataMember]
  public DMD.LineSpacing? LineSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineSpacing>();
      if (element != null)
        return LineSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSpacingConverter.CreateOpenXmlElement<DXD.LineSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Space Before.
  /// </summary>
  [DataMember]
  public DMD.SpaceBefore? SpaceBefore
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SpaceBefore>();
      if (element != null)
        return SpaceBeforeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SpaceBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceBeforeConverter.CreateOpenXmlElement<DXD.SpaceBefore>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Space After.
  /// </summary>
  [DataMember]
  public DMD.SpaceAfter? SpaceAfter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SpaceAfter>();
      if (element != null)
        return SpaceAfterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SpaceAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceAfterConverter.CreateOpenXmlElement<DXD.SpaceAfter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
