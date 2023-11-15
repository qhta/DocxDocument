namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public partial class PageBorders: ModelElement<DXW.PageBorders>
{
  public PageBorders(): base(){ }
  
  public PageBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageBorders(DXW.PageBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Border.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Left Border.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Bottom Border.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Right Border.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
}
