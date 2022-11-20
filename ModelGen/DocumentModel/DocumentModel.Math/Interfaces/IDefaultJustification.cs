namespace DocumentModel.Math;

/// <summary>
/// Default Justification.
/// </summary>
public interface IDefaultJustification // : DocumentFormat.OpenXml.Math.OfficeMathJustificationType
{
  /// <summary>
  /// Value
  /// </summary>
  public DocumentModel.Math.JustificationValues? Val { get ; set; }
  
}
