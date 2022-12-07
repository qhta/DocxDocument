namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public class VbaDataPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, VbaDataPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.VbaSuppData? VbaSuppData
  {
    get;
    set;
  }
  
}
