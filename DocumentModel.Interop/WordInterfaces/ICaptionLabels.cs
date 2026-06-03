namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CaptionLabel objects that represent the available caption labels.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels?view=word-pia"/>
public interface ICaptionLabels : IInteropObject, IInteropCollection<ICaptionLabel>
{


  #region methods

/// <summary>
  /// Adds a custom caption label to the collection.
  /// </summary>
  /// <param name="Name">The name of the caption label to add.</param>
  /// <returns>The created <see cref="ICaptionLabel"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels.add?view=word-pia"/>
  public ICaptionLabel Add(string Name);

  #endregion methods
}
