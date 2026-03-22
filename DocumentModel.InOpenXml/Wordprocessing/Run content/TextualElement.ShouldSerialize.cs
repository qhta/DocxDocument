namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TextualElement<T> 
{
  public bool ShouldSerializeIsDeleted() => IsDeleted == true;
  public bool ShouldSerializeText() => Text is not null;
}
