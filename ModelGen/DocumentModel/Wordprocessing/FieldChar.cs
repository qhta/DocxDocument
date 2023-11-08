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
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  [DataMember]
  public DMW.FormFieldData? FormFieldData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FormFieldData>();
      if (element != null)
        return FormFieldDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FormFieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormFieldDataConverter.CreateOpenXmlElement<DXW.FormFieldData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.NumberingChange>();
      if (element != null)
        return NumberingChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingChangeConverter.CreateOpenXmlElement<DXW.NumberingChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
