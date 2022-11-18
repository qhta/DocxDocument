namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Left Border.
/// </summary>
public interface ILeftBorder // : DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.Border? Type { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public int? Width { get ; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public ITrueFalseValue? Shadow { get ; set; }
  
}
