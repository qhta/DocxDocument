namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view?view=word-pia"/>
public partial interface IView
{
  /// <summary>
  /// Collapses the outline at the specified range.
  /// </summary>
  /// <param name="Range">The range where the outline should be collapsed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.collapseoutline?view=word-pia"/>
  public void CollapseOutline(object Range);
}
