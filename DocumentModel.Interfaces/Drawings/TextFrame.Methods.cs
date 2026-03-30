namespace DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe?view=word-pia"/>
public partial interface TextFrame: IModelObject
{
  /// <summary>
  /// Breaks the forward link for the specified text frame, if such a link exists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.breakforwardlink?view=word-pia"/>
  public void BreakForwardLink();
}
