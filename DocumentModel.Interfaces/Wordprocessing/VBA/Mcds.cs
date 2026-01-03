namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Mcds Class.
/// </summary>
public interface Mcds: IModelElement
{
  public Collection<Mcd>? Items { get; set; }
}