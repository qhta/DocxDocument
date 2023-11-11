namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleField Class.
/// </summary>
public partial class SimpleField: ModelElement<DXW.SimpleField>
{
  public SimpleField(): base(){ }
  
  public SimpleField(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SimpleField(DXW.SimpleField openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field Codes
  /// </summary>
  [DataMember]
  public String? Instruction
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Instruction);
    }
    set
    {
      _ExistingElement.Instruction = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
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
  
}
