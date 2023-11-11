namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scaling.
/// </summary>
public partial class Scaling: ModelElement<DXDC.Scaling>
{
  public Scaling(): base(){ }
  
  public Scaling(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scaling(DXDC.Scaling openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  [DataMember]
  public Double? LogBase
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.LogBase>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.LogBase,System.Double>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  [DataMember]
  public DMDC.OrientationKind? Orientation
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>(_ExistingElement.GetFirstChild<DXDC.Orientation>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Orientation>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>(itemElement, (DMDC.OrientationKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>((DMDC.OrientationKind)value));
    }
  }
  
  
  /// <summary>
  ///   Maximum.
  /// </summary>
  [DataMember]
  public DMDC.MaxAxisValue? MaxAxisValue
  {
    get
    {
      return _Element?.GetObject<DMDC.MaxAxisValue,DXDC.MaxAxisValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MaxAxisValue,DXDC.MaxAxisValue>(value);
    }
  }
  
  
  /// <summary>
  ///   Minimum.
  /// </summary>
  [DataMember]
  public DMDC.MinAxisValue? MinAxisValue
  {
    get
    {
      return _Element?.GetObject<DMDC.MinAxisValue,DXDC.MinAxisValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MinAxisValue,DXDC.MinAxisValue>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
