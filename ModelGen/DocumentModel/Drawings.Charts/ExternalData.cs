namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public partial class ExternalData: ModelElement<DXDC.ExternalData>
{
  public ExternalData(): base(){ }
  
  public ExternalData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExternalData(DXDC.ExternalData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Update Automatically.
  /// </summary>
  [DataMember]
  public DMDC.AutoUpdate? AutoUpdate
  {
    get
    {
      return _Element?.GetObject<DMDC.AutoUpdate,DXDC.AutoUpdate>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.AutoUpdate,DXDC.AutoUpdate>(value);
    }
  }
  
}
