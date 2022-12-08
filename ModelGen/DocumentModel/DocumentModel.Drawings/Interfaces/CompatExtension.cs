namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public interface CompatExtension
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId { get ; set; }
  
}
