using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaDataPart
/// </summary>
public interface VbaDataPart: OpenXmlPart
{


  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public VbaSuppData? VbaSuppData { get; set; }
}