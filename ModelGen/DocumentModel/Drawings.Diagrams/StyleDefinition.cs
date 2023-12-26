namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Definition.
/// </summary>
public partial class StyleDefinition: ModelElement<DXDDD.StyleDefinition>
{
  public StyleDefinition(): base(){ }
  
  public StyleDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDefinition(DXDDD.StyleDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get => _Element?.UniqueId;
    set => _ExistingElement.UniqueId = value;
  }
  
  
  /// <summary>
  ///   Minimum Version
  /// </summary>
  [DataMember]
  public String? MinVersion
  {
    get => _Element?.MinVersion;
    set => _ExistingElement.MinVersion = value;
  }
  
}
