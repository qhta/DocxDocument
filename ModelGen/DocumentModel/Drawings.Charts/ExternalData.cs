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
      var element = _Element?.GetFirstChild<DXDC.AutoUpdate>();
      if (element != null)
        return AutoUpdateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AutoUpdate>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoUpdateConverter.CreateOpenXmlElement<DXDC.AutoUpdate>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
