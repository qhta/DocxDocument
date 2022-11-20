namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Top Border.
/// </summary>
public interface ITopBorder // : DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.BorderValues? Type { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public int? Width { get ; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public ITrueFalseValue? Shadow { get ; set; }
  
}
