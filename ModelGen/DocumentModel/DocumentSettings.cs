namespace DocumentModel;


/// <summary>
///   Document Settings.
/// </summary>
public partial class DocumentSettings: ModelElement<DXW.Settings>
{
  public DocumentSettings(): base(){ }
  
  public DocumentSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentSettings(DXW.Settings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Write Protection.
  /// </summary>
  [DataMember]
  public DMW.WriteProtection? WriteProtection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Document View Setting.
  /// </summary>
  [DataMember]
  public DMW.ViewValues? View
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  [DataMember]
  public DMW.Zoom? Zoom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  [DataMember]
  public DMW.RemovePersonalInformation? RemovePersonalInformation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  [DataMember]
  public DMW.RemoveDateAndTime? RemoveDateAndTime
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  [DataMember]
  public DMW.DoNotDisplayPageBoundaries? DoNotDisplayPageBoundaries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  [DataMember]
  public DMW.DisplayBackgroundShape? DisplayBackgroundShape
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  [DataMember]
  public DMW.PrintPostScriptOverText? PrintPostScriptOverText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  [DataMember]
  public DMW.PrintFractionalCharacterWidth? PrintFractionalCharacterWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  [DataMember]
  public DMW.PrintFormsData? PrintFormsData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  [DataMember]
  public DMW.EmbedTrueTypeFonts? EmbedTrueTypeFonts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  [DataMember]
  public DMW.EmbedSystemFonts? EmbedSystemFonts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  [DataMember]
  public DMW.SaveSubsetFonts? SaveSubsetFonts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  [DataMember]
  public DMW.SaveFormsData? SaveFormsData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  [DataMember]
  public DMW.MirrorMargins? MirrorMargins
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  [DataMember]
  public DMW.AlignBorderAndEdges? AlignBorderAndEdges
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  [DataMember]
  public DMW.BordersDoNotSurroundHeader? BordersDoNotSurroundHeader
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  [DataMember]
  public DMW.BordersDoNotSurroundFooter? BordersDoNotSurroundFooter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  [DataMember]
  public DMW.GutterAtTop? GutterAtTop
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  [DataMember]
  public DMW.HideSpellingErrors? HideSpellingErrors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  [DataMember]
  public DMW.HideGrammaticalErrors? HideGrammaticalErrors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
}
