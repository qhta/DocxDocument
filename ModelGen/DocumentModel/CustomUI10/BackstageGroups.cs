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
      return _Element?.GetObject<DMCUI10.TaskFormGroup,DXO10CUI.TaskFormGroup>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.TaskFormGroup,DXO10CUI.TaskFormGroup>(value);
    }
  }
  
}
