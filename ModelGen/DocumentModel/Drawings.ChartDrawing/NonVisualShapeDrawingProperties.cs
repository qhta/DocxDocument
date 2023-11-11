namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Drawing Properties.
/// </summary>
public partial class NonVisualShapeDrawingProperties: ModelElement<DXDCD.NonVisualShapeDrawingProperties>
{
  public NonVisualShapeDrawingProperties(): base(){ }
  
  public NonVisualShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualShapeDrawingProperties(DXDCD.NonVisualShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Box
  /// </summary>
  [DataMember]
  public Boolean? TextBox
  {
    get
    {
      return _Element?.TextBox?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextBox = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.TextBox = null;
    }
  }
  
  
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  [DataMember]
  public DMD.ShapeLocks? ShapeLocks
  {
    get
    {
      return _Element?.GetObject<DMD.ShapeLocks,DXD.ShapeLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeLocks,DXD.ShapeLocks>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
