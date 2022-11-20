namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Session Revision Save ID.
/// </summary>
public class Rsid: IRsid
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
