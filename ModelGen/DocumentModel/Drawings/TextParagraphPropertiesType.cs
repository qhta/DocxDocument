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
        _ExistingElement.RightToLeft = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.EastAsianLineBreak = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.LatinLineBreak = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.Height = new DX.BooleanValue { Value = (Boolean)value };
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
      return _Element?.GetObject<DMD.LineSpacing,DXD.LineSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LineSpacing,DXD.LineSpacing>(value);
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
      return _Element?.GetObject<DMD.SpaceBefore,DXD.SpaceBefore>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SpaceBefore,DXD.SpaceBefore>(value);
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
      return _Element?.GetObject<DMD.SpaceAfter,DXD.SpaceAfter>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SpaceAfter,DXD.SpaceAfter>(value);
    }
  }
  
}
