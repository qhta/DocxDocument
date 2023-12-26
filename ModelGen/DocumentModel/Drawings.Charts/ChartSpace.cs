namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Chart Space.
/// </summary>
public partial class ChartSpace: ModelElement<DXDC.ChartSpace>
{
  public ChartSpace(): base(){ }
  
  public ChartSpace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpace(DXDC.ChartSpace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Date1904.
  /// </summary>
  [DataMember]
  public DMDC.Date1904? Date1904
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  [DataMember]
  public String? EditingLanguage
  {
    get => _Element?.GetStringVal<DXDC.EditingLanguage>();
    set => _ExistingElement.SetStringVal<DXDC.EditingLanguage>(value);
  }
  
  
  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  [DataMember]
  public DMDC.RoundedCorners? RoundedCorners
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
}
