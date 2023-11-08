namespace DocumentModel.Wordprocessing;


/// <summary>
///   Suggested Filtering for List of Document Styles.
/// </summary>
public partial class StylePaneFormatFilter: ModelElement<DXW.StylePaneFormatFilter>
{
  public StylePaneFormatFilter(): base(){ }
  
  public StylePaneFormatFilter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StylePaneFormatFilter(DXW.StylePaneFormatFilter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [DataMember]
  public DM.HexBinary? Val
  {
    get
    {
      if (_Element?.Val?.Value != null)
        return HexCharConverter.GetValue(_ExistingElement.Val.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Val = value.ToString();
      else
        _ExistingElement.Val = null;
    }
  }
  
  
  /// <summary>
  ///   allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? AllStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.AllStyles);
    }
    set
    {
      _ExistingElement.AllStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? CustomStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.CustomStyles);
    }
    set
    {
      _ExistingElement.CustomStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? LatentStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LatentStyles);
    }
    set
    {
      _ExistingElement.LatentStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? StylesInUse
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.StylesInUse);
    }
    set
    {
      _ExistingElement.StylesInUse = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? HeadingStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.HeadingStyles);
    }
    set
    {
      _ExistingElement.HeadingStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? NumberingStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NumberingStyles);
    }
    set
    {
      _ExistingElement.NumberingStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? TableStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.TableStyles);
    }
    set
    {
      _ExistingElement.TableStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? DirectFormattingOnRuns
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DirectFormattingOnRuns);
    }
    set
    {
      _ExistingElement.DirectFormattingOnRuns = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? DirectFormattingOnParagraphs
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DirectFormattingOnParagraphs);
    }
    set
    {
      _ExistingElement.DirectFormattingOnParagraphs = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? DirectFormattingOnNumbering
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DirectFormattingOnNumbering);
    }
    set
    {
      _ExistingElement.DirectFormattingOnNumbering = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? DirectFormattingOnTables
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DirectFormattingOnTables);
    }
    set
    {
      _ExistingElement.DirectFormattingOnTables = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ClearFormatting
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.ClearFormatting);
    }
    set
    {
      _ExistingElement.ClearFormatting = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Top3HeadingStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Top3HeadingStyles);
    }
    set
    {
      _ExistingElement.Top3HeadingStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? VisibleStyles
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.VisibleStyles);
    }
    set
    {
      _ExistingElement.VisibleStyles = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? AlternateStyleNames
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.AlternateStyleNames);
    }
    set
    {
      _ExistingElement.AlternateStyleNames = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
