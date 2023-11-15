namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the borders for the parent paragraph. Each child element shall specify a specific kind of border (left, right, bottom, top, and between).
/// </summary>
public partial class ParagraphBorders: ModelElement<DXW.ParagraphBorders>
{
  public ParagraphBorders(): base(){ }
  
  public ParagraphBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphBorders(DXW.ParagraphBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.BetweenBorder? BetweenBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  [DataMember]
  public DMW.BarBorder? BarBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
}
