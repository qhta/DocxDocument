namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class PathGradientFill: ModelElement<DXD.PathGradientFill>
{
  public PathGradientFill(): base(){ }
  
  public PathGradientFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PathGradientFill(DXD.PathGradientFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  [DataMember]
  public DMD.FillToRectangle? FillToRectangle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
  }
  
}
