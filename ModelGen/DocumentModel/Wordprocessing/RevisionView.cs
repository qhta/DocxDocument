namespace DocumentModel.Wordprocessing;


/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public partial class RevisionView: ModelElement<DXW.RevisionView>
{
  public RevisionView(): base(){ }
  
  public RevisionView(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RevisionView(DXW.RevisionView openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  [DataMember]
  public Boolean? Markup
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Display Comments
  /// </summary>
  [DataMember]
  public Boolean? Comments
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Display Content Revisions
  /// </summary>
  [DataMember]
  public Boolean? DisplayRevision
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Display Formatting Revisions
  /// </summary>
  [DataMember]
  public Boolean? Formatting
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  [DataMember]
  public Boolean? InkAnnotations
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
