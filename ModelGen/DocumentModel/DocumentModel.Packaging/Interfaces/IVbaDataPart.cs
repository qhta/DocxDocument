namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public interface IVbaDataPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office.Word.IVbaSuppData? VbaSuppData { get ; set; }
  
}
