namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the RowIdIdentifier Class.
/// </summary>
public class RowIdIdentifier: IRowIdIdentifier
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
