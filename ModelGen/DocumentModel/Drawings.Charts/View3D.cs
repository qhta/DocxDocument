namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D view settings.
/// </summary>
public partial class View3D: ModelElement<DXDC.View3D>
{
  public View3D(): base(){ }
  
  public View3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public View3D(DXDC.View3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X Rotation.
  /// </summary>
  [DataMember]
  public SByte? RotateX
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.RotateX>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.RotateX,System.SByte>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Height Percent.
  /// </summary>
  [DataMember]
  public UInt16? HeightPercent
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.HeightPercent>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.HeightPercent,System.UInt16>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Y Rotation.
  /// </summary>
  [DataMember]
  public UInt16? RotateY
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.RotateY>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.RotateY,System.UInt16>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Depth Percent.
  /// </summary>
  [DataMember]
  public UInt16? DepthPercent
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.DepthPercent>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.DepthPercent,System.UInt16>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Right Angle Axes.
  /// </summary>
  [DataMember]
  public DMDC.RightAngleAxes? RightAngleAxes
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.RightAngleAxes>();
      if (element != null)
        return RightAngleAxesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.RightAngleAxes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightAngleAxesConverter.CreateOpenXmlElement<DXDC.RightAngleAxes>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Perspective.
  /// </summary>
  [DataMember]
  public Byte? Perspective
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.Perspective>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.Perspective,System.Byte>(openXmlElement, value);
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
