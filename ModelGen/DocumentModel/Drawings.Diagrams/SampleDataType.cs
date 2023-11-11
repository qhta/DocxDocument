namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public partial class SampleDataType: ModelElement<DXDDD.SampleDataType>
{
  public SampleDataType(): base(){ }
  
  public SampleDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SampleDataType(DXDDD.SampleDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Default
  /// </summary>
  [DataMember]
  public Boolean? UseDefault
  {
    get
    {
      return _Element?.UseDefault?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UseDefault = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UseDefault = null;
    }
  }
  
  
  /// <summary>
  ///   Data Model.
  /// </summary>
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get
    {
      return _Element?.GetObject<DMDD.DataModel,DXDDD.DataModel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.DataModel,DXDDD.DataModel>(value);
    }
  }
  
}
