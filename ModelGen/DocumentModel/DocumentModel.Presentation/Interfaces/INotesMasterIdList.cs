namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterIdList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesMasterId))]
public interface INotesMasterIdList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Notes Master ID.
  /// </summary>
  public INotesMasterId? NotesMasterId { get ; set; }
  
}
