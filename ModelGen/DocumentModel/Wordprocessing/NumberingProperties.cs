namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the current paragraph uses numbering information that is defined by a particular numbering definition instance.
/// </summary>
public partial class NumberingProperties: ModelElement<DXW.NumberingProperties>
{
  public NumberingProperties(): base(){ }
  
  public NumberingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingProperties(DXW.NumberingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level Reference.
  /// </summary>
  [DataMember]
  public Int32? NumberingLevelReference
  {
    get => _Element?.GetIntVal<Int32, DXW.NumberingLevelReference>();
    set => _ExistingElement.SetIntVal<Int32, DXW.NumberingLevelReference>(value);
  }
  
  
  /// <summary>
  ///   Numbering Definition Instance Reference.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? NumberingId
  {
    get => _Element?.GetHexIntVal<DXW.NumberingId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Previous Paragraph Numbering Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingChange? NumberingChange
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
}
