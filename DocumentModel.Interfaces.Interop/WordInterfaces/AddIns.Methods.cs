namespace DocumentModel.Interop;

public partial interface AddIns
{
  /// <summary>
  /// Adds the specified file to the list of available add-ins.
  /// </summary>
  /// <param name="FileName">The path for the template or WLL.</param>
  /// <param name="Install">true to install the add-in; false to add it to the list without installing it.</param>
  /// <returns>The added <see cref="AddIn"/> object.</returns>
  public AddIn Add(string FileName, object Install);

  /// <summary>
  /// Unloads installed add-ins.
  /// </summary>
  /// <param name="RemoveFromList">Specifies whether unloaded add-ins are removed from the list of available add-ins.</param>
  public void Unload(bool RemoveFromList);
}
