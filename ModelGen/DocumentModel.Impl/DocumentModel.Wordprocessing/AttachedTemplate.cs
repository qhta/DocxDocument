namespace DocumentModel.Wordprocessing;

/// <summary>
/// Attached Document Template.
/// </summary>
public class AttachedTemplate: IAttachedTemplate
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
