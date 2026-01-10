namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentTasksPart
/// </summary>
public interface DocumentTasksPart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMUI.TaskCollection? Tasks { get; set; }
}