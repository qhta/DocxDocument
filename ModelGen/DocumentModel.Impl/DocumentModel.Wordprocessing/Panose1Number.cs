namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Panose1Number Class.
/// </summary>
public class Panose1Number: IPanose1Number
{
  /// <summary>
  /// Value
  /// </summary>
  public IHexBinaryValue? Val
  {
    get;
    set;
  }
  
}
