namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ModificationId Class.
/// </summary>
public class ModificationId: IModificationId
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
}
