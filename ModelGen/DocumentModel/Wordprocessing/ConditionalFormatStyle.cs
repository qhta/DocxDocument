namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of conditional table style formatting properties which have been applied to this paragraph, if this paragraph is contained within a table cell.
/// </summary>
public partial class ConditionalFormatStyle: ModelElement<DXW.ConditionalFormatStyle>
{
  public ConditionalFormatStyle(): base(){ }
  
  public ConditionalFormatStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConditionalFormatStyle(DXW.ConditionalFormatStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Conditional Formatting Bit Mask
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? FirstRow
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.FirstRow);
    }
    set
    {
      _ExistingElement.FirstRow = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? LastRow
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LastRow);
    }
    set
    {
      _ExistingElement.LastRow = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? FirstColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.FirstColumn);
    }
    set
    {
      _ExistingElement.FirstColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? LastColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LastColumn);
    }
    set
    {
      _ExistingElement.LastColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? OddVerticalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.OddVerticalBand);
    }
    set
    {
      _ExistingElement.OddVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? EvenVerticalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.EvenVerticalBand);
    }
    set
    {
      _ExistingElement.EvenVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? OddHorizontalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.OddHorizontalBand);
    }
    set
    {
      _ExistingElement.OddHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? EvenHorizontalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.EvenHorizontalBand);
    }
    set
    {
      _ExistingElement.EvenHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? FirstRowFirstColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.FirstRowFirstColumn);
    }
    set
    {
      _ExistingElement.FirstRowFirstColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? FirstRowLastColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.FirstRowLastColumn);
    }
    set
    {
      _ExistingElement.FirstRowLastColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? LastRowFirstColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LastRowFirstColumn);
    }
    set
    {
      _ExistingElement.LastRowFirstColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? LastRowLastColumn
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LastRowLastColumn);
    }
    set
    {
      _ExistingElement.LastRowLastColumn = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
