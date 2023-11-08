namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueAxisScaling Class.
/// </summary>
public partial class ValueAxisScaling: ModelElement<DXO16DCD.ValueAxisScaling>
{
  public ValueAxisScaling(): base(){ }
  
  public ValueAxisScaling(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueAxisScaling(DXO16DCD.ValueAxisScaling openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   max, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Max
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Max);
    }
    set
    {
      _ExistingElement.Max = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   min, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Min
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Min);
    }
    set
    {
      _ExistingElement.Min = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? MajorUnit
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MajorUnit);
    }
    set
    {
      _ExistingElement.MajorUnit = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? MinorUnit
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MinorUnit);
    }
    set
    {
      _ExistingElement.MinorUnit = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
