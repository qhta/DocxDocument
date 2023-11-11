namespace DocumentModel.Wordprocessing;


/// <summary>
///   Complex Field Character.
/// </summary>
public partial class FieldChar: ModelElement<DXW.FieldChar>
{
  public FieldChar(): base(){ }
  
  public FieldChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldChar(DXW.FieldChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  [DataMember]
  public Boolean? FieldLock
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.FieldLock);
    }
    set
    {
      _ExistingElement.FieldLock = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Dirty);
    }
    set
    {
      _ExistingElement.Dirty = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  [DataMember]
  public DMW.FieldData? FieldData
  {
    get
    {
      return _Element?.GetObject<DMW.FieldData,DXW.FieldData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FieldData,DXW.FieldData>(value);
    }
  }
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  [DataMember]
  public DMW.FormFieldData? FormFieldData
  {
    get
    {
      return _Element?.GetObject<DMW.FormFieldData,DXW.FormFieldData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FormFieldData,DXW.FormFieldData>(value);
    }
  }
  
  
  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingChange? NumberingChange
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingChange,DXW.NumberingChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingChange,DXW.NumberingChange>(value);
    }
  }
  
}
