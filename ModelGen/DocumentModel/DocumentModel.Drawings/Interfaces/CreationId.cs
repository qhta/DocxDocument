namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public interface CreationId // : System.Boolean
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
