namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the People Class.
/// </summary>
public interface People: IModelElement
{
  public Collection<Person>? Persons { get; set; }
}