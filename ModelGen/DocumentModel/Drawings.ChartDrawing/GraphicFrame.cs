namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Graphic Frame.
/// </summary>
public partial class GraphicFrame: ModelElement<DXDCD.GraphicFrame>
{
  public GraphicFrame(): base(){ }
  
  public GraphicFrame(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicFrame(DXDCD.GraphicFrame openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Publish To Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualGraphicFrameProperties,DXDCD.NonVisualGraphicFrameProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualGraphicFrameProperties,DXDCD.NonVisualGraphicFrameProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  [DataMember]
  public DMDCD.Transform? Transform
  {
    get
    {
      return _Element?.GetObject<DMDCD.Transform,DXDCD.Transform>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.Transform,DXDCD.Transform>(value);
    }
  }
  
  
  /// <summary>
  ///   Graphical Object.
  /// </summary>
  [DataMember]
  public DMD.Graphic? Graphic
  {
    get
    {
      return _Element?.GetObject<DMD.Graphic,DXD.Graphic>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Graphic,DXD.Graphic>(value);
    }
  }
  
}
