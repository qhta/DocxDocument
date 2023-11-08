namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TickLabels Class.
/// </summary>
public partial class TickLabels: ModelElement<DXO16DCD.TickLabels>
{
  public TickLabels(): base(){ }
  
  public TickLabels(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TickLabels(DXO16DCD.TickLabels openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
