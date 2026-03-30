namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single text column.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn?view=word-pia"/>
public interface ITextColumn : IModelObject
{
  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.width?view=word-pia"/>
  public float Width { get; set; }
  /// <summary>
  /// Returns or sets the amount of spacing (in points) after the specified text column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

}
