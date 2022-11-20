namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public class CompatExtension: ICompatExtension
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
}
