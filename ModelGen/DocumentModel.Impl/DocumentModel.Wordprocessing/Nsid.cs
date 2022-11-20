namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition Identifier.
/// </summary>
public class Nsid: INsid
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
