namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Definitions.
/// </summary>
public partial class ColorsDefinition: ModelElement<DXDDD.ColorsDefinition>
{
  public ColorsDefinition(): base(){ }
  
  public ColorsDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorsDefinition(DXDDD.ColorsDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique ID
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
