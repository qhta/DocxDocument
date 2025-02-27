namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public partial class ExternalData: ModelElement<DXO16DCD.ExternalData>
{
  public ExternalData(): base(){ }
  
  public ExternalData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExternalData(DXO16DCD.ExternalData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? AutoUpdate
  {
    get => _Element?.AutoUpdate?.Value;
    set => _ExistingElement.AutoUpdate = value;
  }
  
}
