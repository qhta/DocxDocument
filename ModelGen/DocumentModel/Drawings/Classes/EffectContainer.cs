namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an Effect Container. It is a list of effects.
/// </summary>
public partial class EffectContainer
{
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
