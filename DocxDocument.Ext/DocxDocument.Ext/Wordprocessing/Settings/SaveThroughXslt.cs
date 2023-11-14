namespace DocumentModel.Wordprocessing;

  /// <summary>
  ///  This element specifies the location of a custom XSL transform which shall be used 
  ///  when this document is saved as a single XML file (in a format not defined by /IEC 29500). 
  ///  [Guidance: Because this setting specifies behavior when saving to an alternative file format not defined by /IEC 29500, 
  ///  this behavior is optional. end guidance]
  /// </summary>
[DataContract]
public partial class SaveThroughXslt: ModelElement<DXW.SaveThroughXslt>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public SaveThroughXslt(): base(){ }

  public SaveThroughXslt(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public SaveThroughXslt(DXW.SaveThroughXslt openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  [DataMember]
  public string? Id
  {
    get => _Element?.Id?.Value;
    set => _ExistingElement.Id = value;
  }

  [DataMember]
  public string? SolutionId
  {
    get => _Element?.SolutionId?.Value;
    set => _ExistingElement.SolutionId = value;
  }

}
