using DocumentModel;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomFilePropertiesPart
/// </summary>
public interface CustomFilePropertiesPart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomProperties? Properties { get; set; }

}