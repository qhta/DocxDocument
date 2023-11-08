namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the current paragraph uses numbering information that is defined by a particular numbering definition instance.
/// </summary>
public partial class NumberingProperties: ModelElement<DXW.NumberingProperties>
{
  public NumberingProperties(): base(){ }
  
  public NumberingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingProperties(DXW.NumberingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level Reference.
  /// </summary>
  [DataMember]
  public Int32? NumberingLevelReference
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.NumberingLevelReference>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.NumberingLevelReference,System.Int32>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Numbering Definition Instance Reference.
  /// </summary>
  [DataMember]
  public DMW.NumberingId? NumberingId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NumberingId>();
      if (element != null)
        return NumberingIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingIdConverter.CreateOpenXmlElement<DXW.NumberingId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Previous Paragraph Numbering Properties.
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
  
  
  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Inserted>();
      if (element != null)
        return InsertedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedConverter.CreateOpenXmlElement<DXW.Inserted>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
