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
        _ExistingElement.UseDefault = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXDDD.DataModel>();
      if (element != null)
        return DataModelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.DataModel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelConverter.CreateOpenXmlElement<DXDDD.DataModel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
