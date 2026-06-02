namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Window objects that represent all the available windows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows?view=word-pia"/>
public interface IWindows : IInteropObject, IInteropCollection<Window>
{
  /// <summary>
  /// True enables scrolling of the contents of windows at the same time. False disables scrolling of windows at the
  /// same time.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.syncscrollingsidebyside?view=word-pia"/>
  public bool SyncScrollingSideBySide { get; set; }


  #region methods

/// <summary>
  /// Adds a new window to the collection.
  /// </summary>
  /// <param name="Window">The window to add to the collection.</param>
  /// <returns>The created <see cref="Window"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.add?view=word-pia"/>
  public Window Add(object Window);

  #endregion methods
}
