namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the People Class.
/// </summary>
public record People
{
  public Collection<Person>? Persons { get; set; }
}