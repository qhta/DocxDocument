namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroups: ModelElement<DXO10CUI.BackstageGroups>
{
  public BackstageGroups(): base(){ }
  
  public BackstageGroups(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageGroups(DXO10CUI.BackstageGroups openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMCUI10.TaskFormGroup? TaskFormGroup
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.TaskFormGroup>();
      if (element != null)
        return TaskFormGroupConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.TaskFormGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskFormGroupConverter.CreateOpenXmlElement<DXO10CUI.TaskFormGroup>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
