namespace DocumentModel.Interop;

/// <summary>
/// A collection of HTMLDivision objects that represents the HTML divisions that exist in a Web document.
/// </summary>
public partial interface HTMLDivisions : InteropObject, InteropCollection<HTMLDivision>
{
  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }
}
