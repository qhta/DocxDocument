namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleFieldRuby Class.
/// </summary>
public partial class SimpleFieldRuby: ModelElement<DXW.SimpleFieldRuby>
{
  public SimpleFieldRuby(): base(){ }
  
  public SimpleFieldRuby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SimpleFieldRuby(DXW.SimpleFieldRuby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   instr
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
  ///   fldLock
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
  ///   dirty
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
  ///   FieldData.
  /// </summary>
  [DataMember]
  public DMW.FieldData? FieldData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FieldData>();
      if (element != null)
        return FieldDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FieldDataConverter.CreateOpenXmlElement<DXW.FieldData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
