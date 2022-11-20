namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the ColIdIdentifier Class.
/// </summary>
public class ColIdIdentifier: IColIdIdentifier
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
}
