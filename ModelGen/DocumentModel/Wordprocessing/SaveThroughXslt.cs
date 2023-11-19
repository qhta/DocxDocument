namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public partial class SaveThroughXslt: ModelElement<DXW.SaveThroughXslt>
{
  public SaveThroughXslt(): base(){ }
  
  public SaveThroughXslt(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveThroughXslt(DXW.SaveThroughXslt openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   XSL Transformation Location
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? SolutionId
  {
    get => HexIntConverter.GetValue(_Element?.SolutionId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
