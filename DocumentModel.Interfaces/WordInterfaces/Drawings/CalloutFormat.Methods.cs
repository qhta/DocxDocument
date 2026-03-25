namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat?view=word-pia"/>
public partial interface CalloutFormat: InteropObject
{
  /// <summary>
  /// Specifies that the first segment of the callout line (the segment attached to the text callout box) be scaled
  /// automatically when the callout is moved.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.automaticlength?view=word-pia"/>
  public void AutomaticLength();
}
