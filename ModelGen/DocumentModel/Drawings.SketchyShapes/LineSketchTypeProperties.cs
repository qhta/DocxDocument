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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
  }
  
  
  /// <summary>
  ///   LineSketchCurvedEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchCurvedEmpty? LineSketchCurvedEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
  }
  
  
  /// <summary>
  ///   LineSketchFreehandEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchFreehandEmpty? LineSketchFreehandEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
  }
  
  
  /// <summary>
  ///   LineSketchScribbleEmpty.
  /// </summary>
  [DataMember]
  public DMDSS.LineSketchScribbleEmpty? LineSketchScribbleEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OpenXmlEmptyElement");
  }
  
}
