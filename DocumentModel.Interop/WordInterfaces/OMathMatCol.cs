namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a matrix column. The OMathMatCol object is a member of the OMathMatCols collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol?view=word-pia"/>
public partial interface OMathMatCol : InteropObject
{
  /// <summary>
  /// The args.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.args?view=word-pia"/>
  public OMathArgs Args { get; }

  /// <summary>
  /// The col index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.colindex?view=word-pia"/>
  public int ColIndex { get; }

  /// <summary>
  /// The align.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.align?view=word-pia"/>
  public WdOMathHorizAlignType Align { get; set; }
}
