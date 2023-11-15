namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a pattern fill. A repeated pattern is used to fill the object.
/// </summary>
public partial class PatternFill: ModelElement<DXD.PatternFill>
{
  public PatternFill(): base(){ }
  
  public PatternFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PatternFill(DXD.PatternFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Foreground color.
  /// </summary>
  [DataMember]
  public DMD.ForegroundColor? ForegroundColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
  
  /// <summary>
  ///   Background color.
  /// </summary>
  [DataMember]
  public DMD.BackgroundColor? BackgroundColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
}
