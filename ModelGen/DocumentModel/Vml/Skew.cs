namespace DocumentModel.Vml;


/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew: ModelElement<DXVO.Skew>
{
  public Skew(): base(){ }
  
  public Skew(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Skew(DXVO.Skew openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Skew ID
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? On
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
  
  
  /// <summary>
  ///   Skew Offset
  /// </summary>
  [DataMember]
  public String? Offset
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Offset);
    }
    set
    {
      _ExistingElement.Offset = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Skew Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Origin);
    }
    set
    {
      _ExistingElement.Origin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  [DataMember]
  public String? Matrix
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Matrix);
    }
    set
    {
      _ExistingElement.Matrix = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
