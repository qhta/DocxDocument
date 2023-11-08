namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextPath Class.
/// </summary>
public partial class TextPath: ModelElement<DXV.TextPath>
{
  public TextPath(): base(){ }
  
  public TextPath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextPath(DXV.TextPath openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
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
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Path Toggle
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
  ///   Shape Fit Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? FitShape
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
  ///   Path Fit Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? FitPath
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
  ///   Text Path Trim Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Trim
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
  ///   Text X-Scaling
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? XScale
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
  ///   Text Path Text
  /// </summary>
  [DataMember]
  public String? String
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.String);
    }
    set
    {
      _ExistingElement.String = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
