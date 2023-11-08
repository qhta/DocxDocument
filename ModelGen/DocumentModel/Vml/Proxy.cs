namespace DocumentModel.Vml;


/// <summary>
///   Shape Reference.
/// </summary>
public partial class Proxy: ModelElement<DXVO.Proxy>
{
  public Proxy(): base(){ }
  
  public Proxy(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Proxy(DXVO.Proxy openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  [DataMember]
  public DM.TrueFalseBlankValue? Start
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseBlankValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseBlankValue,DocumentFormat.OpenXml.TrueFalseBlankValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  [DataMember]
  public DM.TrueFalseBlankValue? End
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseBlankValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseBlankValue,DocumentFormat.OpenXml.TrueFalseBlankValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  [DataMember]
  public String? ShapeReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeReference);
    }
    set
    {
      _ExistingElement.ShapeReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Location
  /// </summary>
  [DataMember]
  public Int32? ConnectionLocation
  {
    get
    {
      return _Element?.ConnectionLocation?.Value;
    }
    set
    {
      _ExistingElement.ConnectionLocation = value;
    }
  }
  
}
