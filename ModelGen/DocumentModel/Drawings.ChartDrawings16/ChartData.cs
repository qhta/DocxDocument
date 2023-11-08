namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartData Class.
/// </summary>
public partial class ChartData: ModelElement<DXO16DCD.ChartData>
{
  public ChartData(): base(){ }
  
  public ChartData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartData(DXO16DCD.ChartData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExternalData.
  /// </summary>
  [DataMember]
  public DMDCD16.ExternalData? ExternalData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExternalData>();
      if (element != null)
        return ExternalDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExternalData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExternalDataConverter.CreateOpenXmlElement<DXO16DCD.ExternalData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
