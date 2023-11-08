namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   For Each.
/// </summary>
public partial class ForEach: ModelElement<DXDDD.ForEach>
{
  public ForEach(): base(){ }
  
  public ForEach(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ForEach(DXDDD.ForEach openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Reference
  /// </summary>
  [DataMember]
  public String? Reference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Reference);
    }
    set
    {
      _ExistingElement.Reference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Axis
  /// </summary>
  [DataMember]
  public DM.ListOf<AxisKind>? Axis
  {
    get
    {
      return ListValueConverter.GetValue<DXDDD.AxisValues, DMDD.AxisKind>(_Element?.Axis);
    }
    set
    {
      if (value != null)
        _ExistingElement.Axis = ListValueConverter.CreateListValue<DXDDD.AxisValues, DMDD.AxisKind>(value);
      else
        _ExistingElement.Axis = null;
    }
  }
  
  
  /// <summary>
  ///   Data Point Type
  /// </summary>
  [DataMember]
  public DM.ListOf<ElementKind>? PointType
  {
    get
    {
      return ListValueConverter.GetValue<DXDDD.ElementValues, DMDD.ElementKind>(_Element?.PointType);
    }
    set
    {
      if (value != null)
        _ExistingElement.PointType = ListValueConverter.CreateListValue<DXDDD.ElementValues, DMDD.ElementKind>(value);
      else
        _ExistingElement.PointType = null;
    }
  }
  
  
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  [DataMember]
  public DM.ListOf<Boolean>? HideLastTrans
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.HideLastTrans);
    }
    set
    {
      if (value != null)
        _ExistingElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
      else
        _ExistingElement.HideLastTrans = null;
    }
  }
  
  
  /// <summary>
  ///   Start
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Start
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.Start);
    }
    set
    {
      if (value != null)
        _ExistingElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
      else
        _ExistingElement.Start = null;
    }
  }
  
  
  /// <summary>
  ///   Count
  /// </summary>
  [DataMember]
  public DM.ListOf<UInt32>? Count
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.Count);
    }
    set
    {
      if (value != null)
        _ExistingElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
      else
        _ExistingElement.Count = null;
    }
  }
  
  
  /// <summary>
  ///   Step
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Step
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.Step);
    }
    set
    {
      if (value != null)
        _ExistingElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
      else
        _ExistingElement.Step = null;
    }
  }
  
}
