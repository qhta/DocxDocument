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
      SimpleValueConverter.SetValue<DXDC.LogBase,System.Double>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXDC.MaxAxisValue>();
      if (element != null)
        return MaxAxisValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MaxAxisValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxAxisValueConverter.CreateOpenXmlElement<DXDC.MaxAxisValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MinAxisValue>();
      if (element != null)
        return MinAxisValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MinAxisValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinAxisValueConverter.CreateOpenXmlElement<DXDC.MinAxisValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
