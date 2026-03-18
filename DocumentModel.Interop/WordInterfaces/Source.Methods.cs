namespace DocumentModel.Interop;

public partial interface Source
{
  /// <summary>
  /// Gets the value of the specified field from the source.
  /// </summary>
  /// <param name="Name">The name of the field to retrieve.</param>
  /// <returns>The value of the specified field as a string.</returns>
  public string get_Field(string Name);

  /// <summary>
  /// Deletes the source.
  /// </summary>
  public void Delete();
}
