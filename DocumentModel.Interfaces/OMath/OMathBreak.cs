namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents individual line breaks in an equation. Each OMathBreak object is a member of the OMathBreaks collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak?view=word-pia"/>
public partial interface IOMathBreak : IModelObject
{
  /// <summary>
  /// Returns the range at the equation line break location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets the alignment position at the line break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.alignat?view=word-pia"/>
  public int AlignAt { get; set; }
}
