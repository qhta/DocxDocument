namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public class CreationId: ICreationId
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
