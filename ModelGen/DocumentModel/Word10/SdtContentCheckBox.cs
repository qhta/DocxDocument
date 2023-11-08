namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that the parent structured document tag is a checkbox when displayed in the document. The parent structured document tag contents MUST contain a single character and optionally an additional character in a deleted run.
/// </summary>
public partial class SdtContentCheckBox: ModelElement<DXO10W.SdtContentCheckBox>
{
  public SdtContentCheckBox(): base(){ }
  
  public SdtContentCheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentCheckBox(DXO10W.SdtContentCheckBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Checked.
  /// </summary>
  [DataMember]
  public DMW10.Checked? Checked
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Checked>();
      if (element != null)
        return CheckedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Checked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckedConverter.CreateOpenXmlElement<DXO10W.Checked>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   CheckedState.
  /// </summary>
  [DataMember]
  public DMW10.CheckedState? CheckedState
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.CheckedState>();
      if (element != null)
        return CheckedStateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.CheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckedStateConverter.CreateOpenXmlElement<DXO10W.CheckedState>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   UncheckedState.
  /// </summary>
  [DataMember]
  public DMW10.UncheckedState? UncheckedState
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.UncheckedState>();
      if (element != null)
        return UncheckedStateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.UncheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UncheckedStateConverter.CreateOpenXmlElement<DXO10W.UncheckedState>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
