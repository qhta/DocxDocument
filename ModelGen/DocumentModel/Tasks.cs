namespace DocumentModel;


/// <summary>
///   Defines the Tasks Class.
/// </summary>
public partial class Tasks: ModelElement<DXO21DT.Tasks>
{
  public Tasks(): base(){ }
  
  public Tasks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tasks(DXO21DT.Tasks openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO21DT.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
