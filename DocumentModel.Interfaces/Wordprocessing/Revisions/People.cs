namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the People Class.
/// </summary>
public class People: ModelElement
{
  public Collection<Person>? Persons { get; set; }
}