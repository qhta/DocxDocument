namespace DocumentModel.Interop.Word;

public partial interface OtherCorrectionsExceptions
{
  /// <summary>
  /// Adds a new correction entry with the specified name and returns the corresponding exception instance. 
  /// </summary>
  /// <param name="Name">The name of the correction to add. Cannot be null or empty.</param>
  /// <returns>An instance of OtherCorrectionsException representing the added correction.</returns>
  public OtherCorrectionsException Add(string Name);
}
