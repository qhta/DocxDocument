namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the relationship for an attached document template in a WordprocessingML document.
/// </summary>
//[OpenXmlUpdateData(nameof(UpdateData))]
public class AttachedTemplate : ExternalFile<DXW.AttachedTemplate>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public AttachedTemplate()
  {
  }

  /// <summary>
  /// Initializes a new instance of the AttachedTemplate class with the specified template URI.
  /// </summary>
  /// <param name="uri">The URI that identifies the template to attach. Cannot be null or empty.</param>
  public AttachedTemplate(string uri): base(uri)
  {
  }

}