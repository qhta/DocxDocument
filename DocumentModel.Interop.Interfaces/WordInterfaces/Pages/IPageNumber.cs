namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a page number in a header or footer.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumber?view=word-pia"/>
public interface IPageNumber : IInteropObject
{
  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumber.index?view=word-pia"/>
  public int Index { get; }	
  /// <summary>
  /// Returns or sets a PageNumberAlignment constant that represents the alignment for the page number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumber.alignment?view=word-pia"/>
  public PageNumberAlignment Alignment { get; set; }	

  #region methods	
/// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumber.select?view=word-pia"/>
  public void Select();	
  #endregion methods
}
