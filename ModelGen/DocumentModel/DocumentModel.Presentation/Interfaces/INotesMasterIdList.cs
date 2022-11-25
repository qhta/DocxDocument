namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterIdList Class.
/// </summary>
public interface INotesMasterIdList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Notes Master ID.
  /// </summary>
  public DocumentModel.Presentation.INotesMasterId? NotesMasterId { get ; set; }
  
}
