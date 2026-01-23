namespace DocumentModel.Wordprocessing;

public partial class TextualElement<T> 
{
  public bool ShouldSerializeIsDeleted() => IsDeleted == true;
  public bool ShouldSerializeText() => Text is not null;
}
