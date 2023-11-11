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
      return _Element?.GetObject<DMW10.Checked,DXO10W.Checked>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Checked,DXO10W.Checked>(value);
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
      return _Element?.GetObject<DMW10.CheckedState,DXO10W.CheckedState>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.CheckedState,DXO10W.CheckedState>(value);
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
      return _Element?.GetObject<DMW10.UncheckedState,DXO10W.UncheckedState>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.UncheckedState,DXO10W.UncheckedState>(value);
    }
  }
  
}
