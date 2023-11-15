namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextParagraphPropertiesType Class.
/// </summary>
public partial class TextParagraphPropertiesType: ModelElement<DXD.TextParagraphPropertiesType>
{
  public TextParagraphPropertiesType(): base(){ }
  
  public TextParagraphPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextParagraphPropertiesType(DXD.TextParagraphPropertiesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Left Margin
  /// </summary>
  [DataMember]
  public Int32? LeftMargin
  {
    get => _Element?.LeftMargin?.Value;
    set => _ExistingElement.LeftMargin = value;
  }
  
  
  /// <summary>
  ///   Right Margin
  /// </summary>
  [DataMember]
  public Int32? RightMargin
  {
    get => _Element?.RightMargin?.Value;
    set => _ExistingElement.RightMargin = value;
  }
  
  
  /// <summary>
  ///   Level
  /// </summary>
  [DataMember]
  public Int32? Level
  {
    get => _Element?.Level?.Value;
    set => _ExistingElement.Level = value;
  }
  
  
  /// <summary>
  ///   Indent
  /// </summary>
  [DataMember]
  public Int32? Indent
  {
    get => _Element?.Indent?.Value;
    set => _ExistingElement.Indent = value;
  }
  
  
  /// <summary>
  ///   Default Tab Size
  /// </summary>
  [DataMember]
  public Int32? DefaultTabSize
  {
    get => _Element?.DefaultTabSize?.Value;
    set => _ExistingElement.DefaultTabSize = value;
  }
  
  
  /// <summary>
  ///   Right To Left
  /// </summary>
  [DataMember]
  public Boolean? RightToLeft
  {
    get => _Element?.RightToLeft?.Value;
    set => _ExistingElement.RightToLeft = value;
  }
  
  
  /// <summary>
  ///   East Asian Line Break
  /// </summary>
  [DataMember]
  public Boolean? EastAsianLineBreak
  {
    get => _Element?.EastAsianLineBreak?.Value;
    set => _ExistingElement.EastAsianLineBreak = value;
  }
  
  
  /// <summary>
  ///   Latin Line Break
  /// </summary>
  [DataMember]
  public Boolean? LatinLineBreak
  {
    get => _Element?.LatinLineBreak?.Value;
    set => _ExistingElement.LatinLineBreak = value;
  }
  
  
  /// <summary>
  ///   Hanging Punctuation
  /// </summary>
  [DataMember]
  public Boolean? Height
  {
    get => _Element?.Height?.Value;
    set => _ExistingElement.Height = value;
  }
  
  
  /// <summary>
  ///   Line Spacing.
  /// </summary>
  [DataMember]
  public DMD.LineSpacing? LineSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
  }
  
  
  /// <summary>
  ///   Space Before.
  /// </summary>
  [DataMember]
  public DMD.SpaceBefore? SpaceBefore
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
  }
  
  
  /// <summary>
  ///   Space After.
  /// </summary>
  [DataMember]
  public DMD.SpaceAfter? SpaceAfter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextSpacingType");
  }
  
}
