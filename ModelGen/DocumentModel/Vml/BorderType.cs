namespace DocumentModel.Vml;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType: ModelElement<DXVW.BorderType>
{
  public BorderType(): base(){ }
  
  public BorderType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderType(DXVW.BorderType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
  
  /// <summary>
  ///   Border shadow
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Shadow
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
}
