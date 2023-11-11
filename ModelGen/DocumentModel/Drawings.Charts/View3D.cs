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
      SimpleValueConverter.SetValue<DXDC.RotateX,System.SByte>(_ExistingElement, value);
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
      SimpleValueConverter.SetValue<DXDC.HeightPercent,System.UInt16>(_ExistingElement, value);
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
      SimpleValueConverter.SetValue<DXDC.RotateY,System.UInt16>(_ExistingElement, value);
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
      SimpleValueConverter.SetValue<DXDC.DepthPercent,System.UInt16>(_ExistingElement, value);
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
      return _Element?.GetObject<DMDC.RightAngleAxes,DXDC.RightAngleAxes>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.RightAngleAxes,DXDC.RightAngleAxes>(value);
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
      SimpleValueConverter.SetValue<DXDC.Perspective,System.Byte>(_ExistingElement, value);
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
