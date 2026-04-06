namespace DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat?view=word-pia"/>
public partial interface ITextEffectFormat: IModelObject
{
  /// <summary>
  /// Switches the text flow in the specified WordArt from horizontal to vertical, or vice versa.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.toggleverticaltext?view=word-pia"/>
  public void ToggleVerticalText();
}
