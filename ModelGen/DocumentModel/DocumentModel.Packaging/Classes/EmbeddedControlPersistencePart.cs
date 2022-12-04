namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public class EmbeddedControlPersistencePart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedControlPersistenceBinaryDataParts
  {
    get;
    set;
  }
  
}
