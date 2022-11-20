namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public interface ILevelReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences { get ; set; }
  
}
