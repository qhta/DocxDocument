namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single text column.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn?view=word-pia"/>
public interface ITextColumn : IModelObject
{
  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.width?view=word-pia"/>
  public float Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Returns or sets the amount of spacing (in points) after the specified text column.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.spaceafter?view=word-pia"/>
  public float SpaceAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
