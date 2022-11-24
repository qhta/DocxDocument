namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterIdList Class.
/// </summary>
public interface INotesMasterIdList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Notes Master ID.
  /// </summary>
  public INotesMasterId? NotesMasterId { get ; set; }
  
}
