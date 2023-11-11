namespace DocumentModel.Drawings.SketchyShapes;


/// <summary>
///   Defines the LineSketchTypeProperties Class.
/// </summary>
public partial class LineSketchTypeProperties: ModelElement<DXO21DSS.LineSketchTypeProperties>
{
  public LineSketchTypeProperties(): base(){ }
  
  public LineSketchTypeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSketchTypeProperties(DXO21DSS.LineSketchTypeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineSketchNoneEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchNoneEmpty? LineSketchNoneEmpty
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchNoneEmpty,DXO21DSS.LineSketchNoneEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchNoneEmpty,DXO21DSS.LineSketchNoneEmpty>(value);
    }
  }
  
  
  /// <summary>
  ///   LineSketchCurvedEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchCurvedEmpty? LineSketchCurvedEmpty
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchCurvedEmpty,DXO21DSS.LineSketchCurvedEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchCurvedEmpty,DXO21DSS.LineSketchCurvedEmpty>(value);
    }
  }
  
  
  /// <summary>
  ///   LineSketchFreehandEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchFreehandEmpty? LineSketchFreehandEmpty
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchFreehandEmpty,DXO21DSS.LineSketchFreehandEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchFreehandEmpty,DXO21DSS.LineSketchFreehandEmpty>(value);
    }
  }
  
  
  /// <summary>
  ///   LineSketchScribbleEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchScribbleEmpty? LineSketchScribbleEmpty
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchScribbleEmpty,DXO21DSS.LineSketchScribbleEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchScribbleEmpty,DXO21DSS.LineSketchScribbleEmpty>(value);
    }
  }
  
}
