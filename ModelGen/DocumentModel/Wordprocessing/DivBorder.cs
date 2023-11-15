namespace DocumentModel.Wordprocessing;


/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public partial class DivBorder: ModelElement<DXW.DivBorder>
{
  public DivBorder(): base(){ }
  
  public DivBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DivBorder(DXW.DivBorder openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Border for HTML div.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Left Border for HTML div.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Bottom Border for HTML div.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Right Border for HTML div.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
}
