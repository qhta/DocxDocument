namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a heading style used when building a table of contents or table of figures.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle?view=word-pia"/>
public interface IHeadingStyle : IInteropObject
{
  /// <summary>
  /// Returns or sets the style associated with the heading style entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle.style?view=word-pia"/>
  public object Style { get; set; }	
  /// <summary>
  /// Returns or sets the outline level associated with the heading style entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle.level?view=word-pia"/>
  public short Level { get; set; }	

  #region methods	
/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}
