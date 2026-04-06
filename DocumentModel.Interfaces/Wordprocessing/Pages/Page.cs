namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a page in a document. Use the Page object and the related methods and properties for
/// programmatically defining page layout in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page?view=word-pia"/>
public partial interface IPage : IModelObject
{
  /// <summary>
  /// Returns 0 (zero) indicating the upper left corner of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.left?view=word-pia"/>
  public int Left { get; }

  /// <summary>
  /// Returns 0 (zero) indicating the upper left corner of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.top?view=word-pia"/>
  public int Top { get; }

  /// <summary>
  /// Returns the width in points (72 points = 1 inch) of the paper size specified in the Page Setup dialog or
  /// through the PageSetup object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.width?view=word-pia"/>
  public int Width { get; }

  /// <summary>
  /// The Height property returns the height in points (72 points = 1 inch) of the paper size specified in the Page
  /// Setup dialog or through the PageSetup object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.height?view=word-pia"/>
  public int Height { get; }

  /// <summary>
  /// Returns a Rectangles collection that represents a portion of text or graphics in a page in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.rectangles?view=word-pia"/>
  public DMD.IRectangles Rectangles { get; }

  /// <summary>
  /// Returns a Breaks collection that represents the breaks on a page. The Breaks collection includes page, column,
  /// and section breaks.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.breaks?view=word-pia"/>
  public IBreaks Breaks { get; }

  /// <summary>
  /// Returns a Object that represents a picture representation of how a page of text appears. Read- only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }
}
