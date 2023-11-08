namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the components of the conditional formatting of the referenced table style (if one exists) which shall be applied to the set of table rows with the current table-level property exceptions. A table style can specify up to six different optional conditional formats, which then can be applied or omitted from individual table rows in the parent table.
/// </summary>
public partial class TableLook: ModelElement<DXW.TableLook>
{
  public TableLook(): base(){ }
  
  public TableLook(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableLook(DXW.TableLook openXmlElement): base(openXmlElement) { }
  
  
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
  ///   noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? NoHorizontalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NoHorizontalBand);
    }
    set
    {
      _ExistingElement.NoHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? NoVerticalBand
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NoVerticalBand);
    }
    set
    {
      _ExistingElement.NoVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
