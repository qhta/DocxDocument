namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied a single latent style for this document. Latent styles refer to any set of known style definitions which have not been included in the current document.
/// </summary>
public partial class LatentStyleExceptionInfo: ModelElement<DXW.LatentStyleExceptionInfo>
{
  public LatentStyleExceptionInfo(): base(){ }
  
  public LatentStyleExceptionInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LatentStyleExceptionInfo(DXW.LatentStyleExceptionInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Primary Style Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Latent Style Locking Setting
  /// </summary>
  [DataMember]
  public Boolean? Locked
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Override default sorting order
  /// </summary>
  [DataMember]
  public Int32? UiPriority
  {
    get => _Element?.UiPriority?.Value;
    set => _ExistingElement.UiPriority = value;
  }
  
  
  /// <summary>
  ///   Semi hidden text override
  /// </summary>
  [DataMember]
  public Boolean? SemiHidden
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Unhide when used
  /// </summary>
  [DataMember]
  public Boolean? UnhideWhenUsed
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Latent Style Primary Style Setting
  /// </summary>
  [DataMember]
  public Boolean? PrimaryStyle
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
