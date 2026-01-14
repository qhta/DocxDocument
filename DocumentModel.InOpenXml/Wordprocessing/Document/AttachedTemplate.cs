namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the relationship for an attached document template in a WordprocessingML document.
/// This interface extends <see cref="ExternalFile"/> and is used to specify the external template file attached to the document, enabling advanced template management and integration for document formatting and styles.
/// </summary>
public class AttachedTemplate : ExternalFile
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public AttachedTemplate()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="uri"></param>
  public AttachedTemplate(string uri) : base(uri)
  {
  }
}