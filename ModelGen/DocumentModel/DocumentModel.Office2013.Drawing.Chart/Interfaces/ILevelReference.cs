namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public interface ILevelReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences { get ; set; }
  
}
