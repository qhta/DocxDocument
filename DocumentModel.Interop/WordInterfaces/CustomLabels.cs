namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CustomLabel objects available in the Label Options dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabels?view=word-pia"/>
public partial interface ICustomLabels : IInteropObject, IInteropCollection<CustomLabel>
{


  #region methods

/// <summary>
  /// Adds a custom label to the collection.
  /// </summary>
  /// <param name="Name">The name of the custom label.</param>
  /// <param name="DotMatrix">Specifies whether the custom label is intended for dot-matrix printing.</param>
  /// <returns>The created <see cref="CustomLabel"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabels.add?view=word-pia"/>
  public CustomLabel Add(string Name, object DotMatrix);

  #endregion methods
}
