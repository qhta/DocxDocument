namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a repeating section item in a content control.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem?view=word-pia"/>
public partial interface IRepeatingSectionItem : IModelObject
{
  /// <summary>
  /// Returns the range of the specified repeating section item, excluding the start and end tags. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem.range?view=word-pia"/>
  public IRange Range { get; }
}
