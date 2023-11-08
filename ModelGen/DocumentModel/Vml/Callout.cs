namespace DocumentModel.Vml;


/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout: ModelElement<DXVO.Callout>
{
  public Callout(): base(){ }
  
  public Callout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Callout(DXVO.Callout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Callout toggle
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
  ///   Callout type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout gap
  /// </summary>
  [DataMember]
  public String? Gap
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Gap);
    }
    set
    {
      _ExistingElement.Gap = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? DropAuto
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
  ///   Callout drop position
  /// </summary>
  [DataMember]
  public String? Drop
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Drop);
    }
    set
    {
      _ExistingElement.Drop = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  [DataMember]
  public String? Distance
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Distance);
    }
    set
    {
      _ExistingElement.Distance = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? LengthSpecified
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
  ///   Callout length
  /// </summary>
  [DataMember]
  public String? Length
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Length);
    }
    set
    {
      _ExistingElement.Length = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AccentBar
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
  ///   Callout text border toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? TextBorder
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
  ///   Callout flip x
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? MinusX
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
  ///   Callout flip y
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? MinusY
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
