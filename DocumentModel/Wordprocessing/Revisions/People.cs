namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the People Class.
/// </summary>
public class People: ModelElement
{
  public Collection<Person>? Persons { get; set; }
}
