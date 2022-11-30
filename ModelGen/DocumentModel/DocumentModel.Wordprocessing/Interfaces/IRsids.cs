namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public interface IRsids // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.BaseTypes.HexWord? RsidRoot { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.BaseTypes.HexWord>? Rsids { get ; set; }
  
}
