namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the relationship for an attached document template in a WordprocessingML document.
/// </summary>
[OpenXmlUpdateDataAttribute(nameof(UpdateData))]
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

  /// <summary>
  /// Updates the current object's data using the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element that provides the data to update the current object. Cannot be null.</param>
  public override void UpdateData(object openXmlElement)
  {
    base.UpdateData(openXmlElement);
  }
}