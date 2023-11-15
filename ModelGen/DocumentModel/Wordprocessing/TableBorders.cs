namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table, using the six border types defined by its child elements.
/// </summary>
public partial class TableBorders: ModelElement<DXW.TableBorders>
{
  public TableBorders(): base(){ }
  
  public TableBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableBorders(DXW.TableBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Left Border.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartBorder? StartBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Bottom Border.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Right Border.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndBorder? EndBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideHorizontalBorder? InsideHorizontalBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideVerticalBorder? InsideVerticalBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
}
