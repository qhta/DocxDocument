namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the ShapeMoniker Class.
/// </summary>
public class ShapeMoniker: IShapeMoniker
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// creationId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CreationId
  {
    get;
    set;
  }
  
}
