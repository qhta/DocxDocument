namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public interface IRsids // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public IRsidRoot? RsidRoot { get ; set; }
  
}
