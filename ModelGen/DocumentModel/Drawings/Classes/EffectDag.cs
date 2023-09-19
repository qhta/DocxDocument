namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a list of effects. Effects are applied in the order specified by the container type (sibling or tree).
/// </summary>
public partial class EffectDag
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
