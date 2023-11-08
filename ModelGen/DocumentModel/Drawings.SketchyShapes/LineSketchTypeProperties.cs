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
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchNoneEmpty>();
      if (element != null)
        return LineSketchNoneEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchNoneEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchNoneEmptyConverter.CreateOpenXmlElement<DXO21DSS.LineSketchNoneEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchCurvedEmpty>();
      if (element != null)
        return LineSketchCurvedEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchCurvedEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchCurvedEmptyConverter.CreateOpenXmlElement<DXO21DSS.LineSketchCurvedEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchFreehandEmpty>();
      if (element != null)
        return LineSketchFreehandEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchFreehandEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchFreehandEmptyConverter.CreateOpenXmlElement<DXO21DSS.LineSketchFreehandEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchScribbleEmpty>();
      if (element != null)
        return LineSketchScribbleEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchScribbleEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchScribbleEmptyConverter.CreateOpenXmlElement<DXO21DSS.LineSketchScribbleEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
