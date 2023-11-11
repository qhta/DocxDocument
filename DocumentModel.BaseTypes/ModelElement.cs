namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class ModelElement: IModelElement
{

  public ModelElement? Parent 
  { 
    get => _Parent; 
    set => SetParent(value); 
  }

  protected virtual void SetParent(ModelElement? parent)
    => _Parent = parent;

  protected ModelElement? _Parent;

}

