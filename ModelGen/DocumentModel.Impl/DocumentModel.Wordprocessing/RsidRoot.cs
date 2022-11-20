namespace DocumentModel.Wordprocessing;

/// <summary>
/// Original Document Revision Save ID.
/// </summary>
public class RsidRoot: IRsidRoot
{
  /// <summary>
  /// Long Hexadecimal Number Value
  /// </summary>
  public IHexBinaryValue? Val
  {
    get;
    set;
  }
  
}
